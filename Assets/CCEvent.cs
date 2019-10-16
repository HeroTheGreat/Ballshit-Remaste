using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCEvent : MonoBehaviour
{
    Renderer rend;
    
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            rend.material.SetColor("_Color",Color.green);
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            rend.material.SetColor("_Color", Color.red);
        }
    }
}

