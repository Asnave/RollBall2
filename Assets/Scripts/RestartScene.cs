using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{

    

    void Start()
    {
        print("This scene has been loaded");
    }

   public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        DontDestroyOnLoad(gameObject);
    }
}