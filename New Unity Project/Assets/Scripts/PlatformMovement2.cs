using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PlatformMovement2 : MonoBehaviour
{
  
   
    public Vector2 startpoint;
    public Vector2 endpoint;
    
    public float speed;

    private Vector2 currentPlatformPosition;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

        currentPlatformPosition = Vector2.Lerp(startpoint, endpoint, Mathf.PingPong(Time.time * speed, 1));
        transform.position = currentPlatformPosition;
    }
        void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log(other.gameObject.name);
            other.transform.parent = transform;
        }
        void OnTriggerExit2D(Collider2D other)
        {
            Debug.Log(other.gameObject.name + " - OUT");
            other.transform.parent = null;
        }

    }
