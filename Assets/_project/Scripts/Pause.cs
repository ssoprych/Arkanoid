using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public void Continue()
    {
        this.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Arkanoid.score = 0;
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
