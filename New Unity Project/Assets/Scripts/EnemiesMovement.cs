using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemiesMovement : MonoBehaviour
{

    public float speed;
    public bool MoveRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MoveRight)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(-1, 1);
        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(1, 1);
        }
    
   }
        void OnTriggerEnter2D(Collider2D trig)
    {
        if(trig.gameObject.CompareTag("turn"))
        {
            if (MoveRight)
            {
                MoveRight = false;
            }
            
                else
                {
                    MoveRight = true;
                }
            }
        }

    }

