using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public Animator transition;
  public float transitionTime = 1f;
    public GameObject introPS;
    public GameObject pressedPS;

    private void Start()
    {
        introPS.SetActive(true);
        pressedPS.SetActive(false);
    }

    public void PressedPS()
    {
        pressedPS.SetActive(true);
        introPS.SetActive(false);
    }
    public void PlayGame ()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        DontDestroyOnLoad(gameObject);
    }
    public void BackToMenu ()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        DontDestroyOnLoad(gameObject);
    }
 
    public void ExitGame ()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
 
}
