using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] int lifeCnt;
    [SerializeField] float ballSpeed = 0.3f;
    [SerializeField] UnityEngine.UI.Text lifeCntText;


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

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Death"))
        {
            lifeCnt--;
            lifeCntText.text = "Lifes: " + lifeCnt.ToString();
        }
    }

    //When the player loses for 3 times, it is Game Over!
    void LoseProcess()
    {

    }
}
