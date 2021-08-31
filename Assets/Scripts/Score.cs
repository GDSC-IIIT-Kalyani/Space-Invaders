using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int alien = 0;
    public static int coin = 0;
    public static int highScore = 0;

    public Text aliens;
    public Text coins;
    public Text highest;

    private void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
        }
        else
        {
            highScore = 0;
        }
    }

    private void Update()
    {
        aliens.text = "Aliens : " + alien.ToString();
        coins.text = "Coins : " + coin.ToString();
        highest.text = "Highest : " + highScore.ToString();
        SaveHighScore();
    }

    private void SaveHighScore()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
        PlayerPrefs.Save();
    }
}
