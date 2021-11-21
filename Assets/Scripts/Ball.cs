using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] int lifeCnt;
    [SerializeField] float ballSpeed = 0.3f;


    // Start is called before the first frame update
    void Start()
    {
        lifeCnt = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(lifeCnt <= 0)
        {
            LoseProcess();
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Death"))
        {
            lifeCnt--;
        }
    }
    //When the player loses for 3 times, it is Game Over!
    void LoseProcess()
    {

    }
}
