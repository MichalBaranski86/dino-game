using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class CounterController : MonoBehaviour
{

    int ilośćSztabek;
 public Text counterView;

 

    // Start is called before the first frame update
    void Start() 
    {

        ResetCounter ();
    }
    
    public void IncrementCounter()
    {
        
        ilośćSztabek++;
       counterView.text = ilośćSztabek.ToString();   
        
        if (ilośćSztabek >=15)
       
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

 
    

    // Update is called once per frame
   public void ResetCounter ()
    {
        ilośćSztabek = 0;
        counterView.text = ilośćSztabek.ToString ();
    }
    




}
