using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Arkanoid : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    public static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _scoreText.text = "SCORE:" + score;
    }
}
