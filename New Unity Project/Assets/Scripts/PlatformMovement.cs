using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PlatformMovemen : MonoBehaviour
{

    public Transform platforma;


    public Transform Punkt;

    private Vector3 pozycjaA;

    private Vector3 pozycjaB;

    private Vector3 następnaPozycja;


    [SerializeField]

    private float speed = 8;



    // Start is called before the first frame update
    void Start()
    {
        pozycjaA = platforma.localPosition;
       
        pozycjaB = Punkt.localPosition;
        następnaPozycja = pozycjaB;
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
    }

    private void Move()
    {
        platforma.localPosition = Vector3.MoveTowards(platforma.localPosition, następnaPozycja, speed * Time.deltaTime); 

        if (Vector3.Distance(platforma.localPosition, następnaPozycja) <= 0.1)
        {
            ChangeDestination();
        }
    }
    private void ChangeDestination()
    {
        
        następnaPozycja = następnaPozycja != pozycjaA ? pozycjaA : pozycjaB;
       
    }
    

   
    }


