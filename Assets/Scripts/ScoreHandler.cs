using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    public int score;
    public Text scoredisplay;

    private void Update()
    {
        scoredisplay.text = score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Obstacle"))
        {
            score++;
            Debug.Log(score);
        }
    }

}
