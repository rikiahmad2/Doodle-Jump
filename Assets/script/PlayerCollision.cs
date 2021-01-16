using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Player movement;
    public Text gameOver;
    public Button restartButton;
    //public Text text;
    private Transform posisi;
    private BoxCollider2D myColid;
    private bool isDead = false;
    private Rigidbody2D rb;
    //private Color test;

    void Start()
    {
        myColid = GetComponent<BoxCollider2D>();
        posisi = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Rintangan")
        {
            movement.enabled = false;
            myColid.enabled = false;
            isDead = true;
            gameOver.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
        }
    }
    void FixedUpdate()
    {
        if (isDead)
        {
            rb.constraints = RigidbodyConstraints2D.None;
            posisi.Rotate(Vector3.forward*Time.deltaTime*500f);
        }  
    }
}