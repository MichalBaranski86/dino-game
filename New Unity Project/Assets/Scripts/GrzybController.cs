using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GrzybController : MonoBehaviour
{
    public Transform startPoint;




    void Start()
    {
        
    }
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.name == "Smok")
        {
            other.transform.position = startPoint.position;
        }
    }
}
