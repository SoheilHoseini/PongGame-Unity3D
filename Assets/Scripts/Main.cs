using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] float speed = 0.3f;
    [SerializeField] float movingAmount = 0.2f;
    [SerializeField] bool MainPlayer;

    // Update is called once per frame
    void Update()
    {
        //Moving Up
        if(Input.GetKey(KeyCode.UpArrow))
        {
            if(MainPlayer == true)
            {
                gameObject.transform.Translate(0f, movingAmount * speed * Time.deltaTime, 0f);
            }
            else
            {
                gameObject.transform.Translate(0f, -1 * movingAmount * speed * Time.deltaTime, 0f);
            }
        }

        //Moving Down
        if(Input.GetKey(KeyCode.DownArrow))
        {
            if (MainPlayer == true)
            {
                gameObject.transform.Translate(0f, -1 * movingAmount * speed * Time.deltaTime, 0f);
            }
            else
            {
                gameObject.transform.Translate(0f, movingAmount * speed * Time.deltaTime, 0f);
            }
        }
    }
}
