using UnityEngine;

public class CoinReplacer : MonoBehaviour
{
    public GameObject coin;
    private float time;
    private float lastTime = 0;
    public float timeInterval;

    void Update()
    {
        time = Time.time;
        if (time - lastTime > timeInterval)
        {
            GameObject newCoin = Instantiate(coin);
            newCoin.transform.position = new Vector3(Random.Range(-10, 10), 17, 0);
            Destroy(newCoin, 50);
            lastTime = time;
        }
    }
}
