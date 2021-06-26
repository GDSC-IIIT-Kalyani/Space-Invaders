using System.Collections;
using System.Collections.Generic;
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
            newAlien.transform.position = new Vector3(Random.Range(-10, 10), 17, 0);
            Destroy(newAlien, 20);
            lastTime = time;
        }
    }
}
