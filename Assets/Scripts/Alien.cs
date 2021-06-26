using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    private bool stop = false;
    public GameObject alien;

    private void Update()
    {
        if (transform.position.y > -300 || !stop)
        {
            transform.position += new Vector3(0, -0.05f, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SpaceShip"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Pause();
        }
    }

    private void Pause()
    {
        Time.timeScale = 0;
        stop = true;
    }
}
