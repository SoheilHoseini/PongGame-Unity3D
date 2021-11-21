using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] int lifeCnt;
    [SerializeField] float ballSpeed = 0.3f;
    [SerializeField] UnityEngine.UI.Text lifeCntText;
    [SerializeField] UnityEngine.UI.Text gameOver;

    void Start()
    {
        lifeCnt = 3;
        float xDir = Random.Range(0, 2) == 0 ? -1 : 1;
        float yDir = Random.Range(0, 2) == 0 ? -1 : 1;


        Vector3 move = new Vector3(xDir * ballSpeed, yDir * ballSpeed, 0f);
        GetComponent<Rigidbody>().velocity = move;
        
    }


    void Update()
    {
        if(lifeCnt <= 0)
        {
            LoseProcess();
        }

        else
        { gameOver.text = ""; }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Death"))
        {
            lifeCnt--;
            lifeCntText.text = "Lifes: " + lifeCnt.ToString();
            gameObject.transform.position = new Vector3(0f, 0f, 0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 currentMove = GetComponent<Rigidbody>().velocity;

        ////GetComponent<Rigidbody>().velocity = new Vector3(currentMove.x, -currentMove.y, 0f);
        //GetComponent<Rigidbody>().AddForce(currentMove.x , -currentMove.y *10, 0f);

        if (collision.collider.CompareTag("Player"))
        {
            Vector3 vel;
            vel.x = currentMove.x;
            vel.y = (currentMove.y / 2) + (collision.collider.attachedRigidbody.velocity.y / 3);
            vel.z = 0f;
            //rb2d.velocity = vel;
            GetComponent<Rigidbody>().velocity = vel;
        }
    }

    //When the player loses for 3 times, it is Game Over!
    void LoseProcess()
    {
        gameOver.text = "Game Over!";
        lifeCnt = 3;
    }
}
