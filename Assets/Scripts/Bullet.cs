using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.y < 300)
        {
            transform.position += new Vector3(0, 0.1f, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Alien"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Score.alien++;
        }
    }
}
