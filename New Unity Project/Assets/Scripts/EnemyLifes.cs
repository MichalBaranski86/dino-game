using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLifes : MonoBehaviour
{
    // Start is called before the first frame update

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Smok")
        {
            

            other.gameObject.GetComponent<Animator>().SetTrigger("fail");
            
            LifesController.Serce -= 1;
     


        }

       
       
            }
        }


