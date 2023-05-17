using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovPlataforma : MonoBehaviour
{
    
    public Transform Plataforma;
    
   
    
    public float velocidad;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            Plataforma.Rotate(Vector2.up * velocidad);
        
        }
        if (Input.GetKey(KeyCode.S)) 
        {
            Plataforma.Rotate(Vector2.down*velocidad);
        
        }
    }
}
