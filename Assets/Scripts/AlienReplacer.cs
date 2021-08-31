using UnityEngine;

public class AlienReplacer : MonoBehaviour
{
    public GameObject alien;
    private float time;
    private float lastTime = 0;
    public float timeInterval;

    void Update()
    {
        time = Time.time;
        if (time - lastTime > timeInterval)
        {
            GameObject newAlien = Instantiate(alien);
            newAlien.transform.position = new Vector3(Random.Range(-9, 9), 17, 0);
            Destroy(newAlien, 50);
            lastTime = time;
        }
    }
}
