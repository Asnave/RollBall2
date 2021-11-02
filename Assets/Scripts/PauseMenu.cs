using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{


    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;

    /// public Animator transition;
    //// public float transitionTime = 1f;
    public PlayerControl movement;

    public void Start()
    {

    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }
    }
    ////  IEnumerator LoadLevel(int levelIndex)
    //{
    ///    transition.SetTrigger("Start");

    /// yield return new WaitForSeconds(transitionTime);

    /// SceneManager.LoadScene(levelIndex);

    //public void BackToMenu()
    // {
    //   StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));
    //  DontDestroyOnLoad(gameObject);
    //  }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        movement.enabled = true;
    }

    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        movement.enabled = false;


    }
    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        
    }
}
