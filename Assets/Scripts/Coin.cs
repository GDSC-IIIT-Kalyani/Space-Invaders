using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void Update()
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
            Destroy(gameObject);
            Score.coin++;
        }
    }
}
