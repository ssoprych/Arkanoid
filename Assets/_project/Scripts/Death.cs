using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    private void Start()
    {
        FindObjectOfType<AudioManager>().Lose.Play();
    }
    public void MainMenuiguess()
    {
        SceneManager.LoadScene(0);
    }

    public void RetryAndRestartLol()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Arkanoid.score = 0;
        Time.timeScale = 1;
    }

}
