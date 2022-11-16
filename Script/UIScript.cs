using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    [SerializeField] GameObject gameOverSceneByMenuButton;
    [SerializeField] GameObject insideeOptionMenu;
    

    public void RestartGame()
    {
        Time.timeScale = 1;
        StartCoroutine(RestartGameCall());
    }

    public IEnumerator RestartGameCall()
    {
        yield return new WaitForSeconds(0.5f);
        gameOverSceneByMenuButton.SetActive(false);
        SceneManager.LoadScene("Dot_Level_1");
    }

    public void QuitGame()
    {
        StartCoroutine(QuitGameCall());
    }

    public IEnumerator QuitGameCall()
    {
        Time.timeScale = 1;
        yield return new WaitForSeconds(0.5f);
        Application.Quit();
    }

    public void MenuButton()
    {
        gameOverSceneByMenuButton.SetActive(true);
        Time.timeScale = 0;
    }

    public void OptionButton()
    {
        insideeOptionMenu.SetActive(true);
    }

    public void BackToMenu()
    {
        insideeOptionMenu.SetActive(false);
    }

    public void ResumeButton()
    {
        gameOverSceneByMenuButton.SetActive(false);
        Time.timeScale = 1;
    }
}
