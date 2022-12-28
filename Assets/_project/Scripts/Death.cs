using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{

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
