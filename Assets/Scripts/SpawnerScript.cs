using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject[] ObstaclePatterns;
    private float timebtwspawn;
    public float starttimespawn;
    public float decreasetime;
    public float mintime = 0.65f;

    private void Update()
    {
        if(timebtwspawn <=0)
        {
            int rand = Random.Range(0, ObstaclePatterns.Length);
            Instantiate(ObstaclePatterns[rand], transform.position, Quaternion.identity);
            timebtwspawn = starttimespawn;
            if (starttimespawn >= mintime)
            {
                starttimespawn -= decreasetime;
            }
        }
        else
        {
            timebtwspawn -= Time.deltaTime;
        }
    }
}
