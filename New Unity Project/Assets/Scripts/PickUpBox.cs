using System.Collections;
using System.Security.Cryptography;
using UnityEngine;


public class PickUpBox : MonoBehaviour
{

    CounterController counterController;
    public AudioSource source;
    int ilośćSztabek;
   
  
    // Start is called before the first frame update
    void Start()
    {

        source = GetComponent<AudioSource>();

        counterController = GameObject.Find("Manager").GetComponent<CounterController>();
      if (counterController == null)
        {
            Debug.LogError("CounterController nie został znaleziony");
        }

        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        source.Play();

        if (other.gameObject.name == "Smok")

            Destroy(gameObject, 0.3f);





        counterController.IncrementCounter();
       


    }
    }

