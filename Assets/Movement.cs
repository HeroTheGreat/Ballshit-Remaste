using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 1;


    void Start()
    {
        
    }

 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(1.0f * speed, 0.0f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1.0f * speed, 0.0f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0.0f, -1.0f * speed, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0.0f, 1.0f * speed, 0.0f);
        }
    }
}
