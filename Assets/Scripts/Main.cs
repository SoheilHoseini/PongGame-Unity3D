using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] float speed = 3f;
    [SerializeField] float movingAmount = 0.2f;
    [SerializeField] bool MainPlayer;
    [SerializeField] UnityEngine.UI.Text scoreText;
    private int score;
    // Update is called once per frame
    void Update()
    {
        score = 0;

        //Moving Up
        if(Input.GetKey(KeyCode.UpArrow))
        {
            if(MainPlayer == true)
            {
                gameObject.transform.Translate(0f, movingAmount * speed , 0f);
            }
            else
            {
                gameObject.transform.Translate(0f, -1 * movingAmount * speed, 0f);
            }
        }

        //Moving Down
        if(Input.GetKey(KeyCode.DownArrow))
        {
            if (MainPlayer == true)
            {
                gameObject.transform.Translate(0f, -1 * movingAmount * speed, 0f);
            }
            else
            {
                gameObject.transform.Translate(0f, movingAmount * speed, 0f);
            }
        }

       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            score++;
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
