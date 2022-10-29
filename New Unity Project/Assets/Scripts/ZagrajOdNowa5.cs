using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZagrajOdNowa5 : MonoBehaviour
{

    // Start is called before the first frame update
    void Awake()
    {

        Time.timeScale = 1;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(5);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
