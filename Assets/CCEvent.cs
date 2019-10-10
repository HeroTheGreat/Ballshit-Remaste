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

    private void OnTriggerEnter(Collider collider)
    {
        SetRendererColorIfTagIsPlayer(collider, Color.green);
    }

    void OnTriggerExit(Collider collider)
    {
        SetRendererColorIfTagIsPlayer(collider, Color.red);
    }

    private void SetRendererColorIfTagIsPlayer(Collider collider, Color color)
    {
        if (collider.CompareTag("Player"))
        {
            rend.material.SetColor("_Color", color);
        }
    }
}