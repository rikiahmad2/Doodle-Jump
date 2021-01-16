using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class movement : MonoBehaviour {

    Rigidbody2D rb;
    public float movementS = 10f;
    float gerak= 0f;
    float jump = 5f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        gerak = Input.GetAxis("Horizontal") * movementS;
	}
    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = gerak;
        rb.velocity = velocity;
        if (Input.GetButtonDown("W"))
        {
            velocity = rb.velocity;
            velocity.y = jump;
            rb.velocity = velocity;
        }
    }
}
