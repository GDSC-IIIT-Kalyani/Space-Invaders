using UnityEngine;
using UnityEngine.UI;

public class Alien : MonoBehaviour
{
    private bool stop = false;
    public GameObject spaceship;
    public AudioSource end;
    public Button replay;

    private void Start()
    {
        replay.gameObject.SetActive(false);
        replay.onClick.AddListener(Restart);
    }

    private void Update()
    {
        if (transform.position.y > -300 || !stop)
        {
            transform.position += new Vector3(0, -0.05f, 0);
        }
    }

    private void Restart()
    {
        replay.gameObject.SetActive(false);
        Time.timeScale = 1;
        stop = false;
        spaceship.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SpaceShip"))
        {
            end.Play();
            Destroy(gameObject);
            Pause();
        }
    }

    private void Pause()
    {
        replay.gameObject.SetActive(true);
        Time.timeScale = 0;
        stop = true;
        Score.alien = 0;
        Score.coin = 0;
        spaceship.SetActive(false);
    }
}
