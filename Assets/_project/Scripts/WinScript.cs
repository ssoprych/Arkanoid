using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    [SerializeField] private TMP_Text _endingScoreText;
    // Update is called once per frame
    void Update()
    {
        _endingScoreText.text = "Your score was: " + Arkanoid.score;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
