using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawno : MonoBehaviour
{
    public GameObject[] objeler;
    public Transform[] cubes;
    void Start()
    {
        for (int i = 0; i < 1; i++) ;
        Instantiate(objeler[Random.Range(0, objeler.Length)], cubes[Random.Range(0, cubes.Length)].position,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
