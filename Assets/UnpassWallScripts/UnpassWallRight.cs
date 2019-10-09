using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnpassWallRight : MonoBehaviour
{

    public float speed = 1;

    void Start()
    {

    }




    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            other.transform.Translate(1.0f * speed, 0.0f, 0.0f);

        }
    }
}
