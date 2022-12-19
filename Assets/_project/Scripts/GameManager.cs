using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int BallCount;
    public int Health = 3;
    public GameObject Ball;
    public Transform BallSpawn;
    private bool _DidplayerLoseHeart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BallCount == 0 && !_DidplayerLoseHeart)
        {
            _DidplayerLoseHeart = true;
            Health--;
            if (Health <= 0)
            {
                // Death screen
                print("You lose");
            }
            else
            {
                Instantiate(Ball, BallSpawn.transform.position, BallSpawn.transform.rotation);
                _DidplayerLoseHeart = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
        }
    }
}
