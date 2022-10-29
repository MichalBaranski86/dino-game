using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZagrajOdNowa : MonoBehaviour
{

    // Start is called before the first frame update
    void Awake() 
    {
    
        Time.timeScale = 1;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
