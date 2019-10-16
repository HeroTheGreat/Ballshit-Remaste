using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCEventSphere : MonoBehaviour
    
{
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            rend.material.SetColor("_Color", Color.green);
        }
    }
}
