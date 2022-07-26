using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    
   private Vector2 targetPos;
   public float Yinc;

   public float speed;
   public float minh;
   public float maxh;
    public GameObject playereffect;
    public int health = 3;
    public Text hpdisplay;

   
    void PauseGame()
    {
        Time.timeScale = 0;
       
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public GameObject gameover;
    void Update()
    {
        


        hpdisplay.text = health.ToString();
        if(health<=0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        transform.position = Vector2.MoveTowards(transform.position,targetPos,speed * Time.deltaTime);
        if((Input.GetKeyDown(KeyCode.UpArrow) || SwipeManager.swipeUp)  && transform.position.y <maxh)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yinc);
            Instantiate(playereffect, transform.position, Quaternion.identity);

        }
        else if((Input.GetKeyDown(KeyCode.DownArrow) || SwipeManager.swipeDown ) && transform.position.y >minh)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yinc);
            Instantiate(playereffect, transform.position, Quaternion.identity);


        }
    }
}
