using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifesController : MonoBehaviour
{

    public GameObject Serce1, Serce2, Serce3, gameOver;
        public static int Serce;
    // Start is called before the first frame update
    void Start()
    {
        Serce = 3;
        Serce1.gameObject.SetActive(true);
        Serce2.gameObject.SetActive(true);
        Serce3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Serce > 3)
            Serce = 3;
        switch (Serce)
        {
            case 3:
                Serce1.gameObject.SetActive(true);
                Serce2.gameObject.SetActive(true);
                Serce3.gameObject.SetActive(true);
                break;

            case 2:
                Serce1.gameObject.SetActive(true);
                Serce2.gameObject.SetActive(true);
                Serce3.gameObject.SetActive(false);
                break;
            case 1:
                Serce1.gameObject.SetActive(true);
                Serce2.gameObject.SetActive(false);
                Serce3.gameObject.SetActive(false);
                break;

            case 0:
                Serce1.gameObject.SetActive(false);
                Serce2.gameObject.SetActive(false);
                Serce3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
               
                Time.timeScale = 0;
                
                
              
                break;


        }
        
    }


}
