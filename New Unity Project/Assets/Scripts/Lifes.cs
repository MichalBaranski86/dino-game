using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifes : MonoBehaviour
{
    public AudioSource source;



    void Start()
    {

        source = GetComponent<AudioSource>();

       
        }
        // Start is called before the first frame update
        void OnTriggerEnter2D(Collider2D other)
    {
        source.Play();
        if (other.gameObject.name == "Smok")
                Destroy(this.gameObject, 0.4f);
            LifesController.Serce += 1;
    }
}

