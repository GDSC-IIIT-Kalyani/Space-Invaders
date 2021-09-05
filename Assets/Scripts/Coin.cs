using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource coin;

    private void Update()
    {
        if (transform.position.y > -300)
        {
            transform.position += new Vector3(0, -0.02f, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SpaceShip"))
        {
            coin.Play();
            Destroy(gameObject);
            Score.coin++;
            if (Score.coin >= Score.highScore)
            {
                Score.highScore = Score.coin;
            }
        }
    }
}
