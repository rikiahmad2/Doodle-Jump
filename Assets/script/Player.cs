using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {

    public float movementSpeed = 10f;

    [Header("Setting Bullet")]
    public GameObject Prefab;
    public float BulletSpeed = 15f;
    public Vector3 offset;

    Animator anim;
    Rigidbody2D rb;
    float movement = 0f;
    internal static readonly object collisionInfo;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float move = Input.GetAxis("Horizontal");
        Vector2 test = new Vector2(move * movementSpeed, movement);
        rb.AddForce(test);

        if (Input.GetMouseButtonDown(0))
        {
            GameObject _instObject = Instantiate(Prefab, transform.position + offset, Quaternion.identity);
            _instObject.GetComponent<Rigidbody2D>().AddForce(transform.up * BulletSpeed, ForceMode2D.Impulse);
            anim.SetBool("isShoot", true);
            Destroy(_instObject, 2f);
        }
        else
        {
            anim.SetBool("isShoot", false);
        }
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }
}
