using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrip : MonoBehaviour
{

    public Material[] material;
    Renderer rend;


    // Use this for initialization
    void Start()
    {

        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];

    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Box")
        {
            rend.sharedMaterial = material[1]; 

        }
   

    }

}

