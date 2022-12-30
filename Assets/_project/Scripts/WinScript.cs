using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    [SerializeField] private TMP_Text _endingScoreText;
    // Update is called once per frame
    void Update()
    {
        _endingScoreText.text = "Your score was: " + Arkanoid.score;
    }

    private void Start()
    {
        FindObjectOfType<AudioManager>().Win.Play();
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Arkanoid.score = 0;
        Time.timeScale = 1;
    }
    public void Quit()
    {
        SceneManager.LoadScene(0);
    }
}
