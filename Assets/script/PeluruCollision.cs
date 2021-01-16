using UnityEngine;

public class PeluruCollision : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Peluru")
        {
            Destroy(gameObject);
        }
    }
}
