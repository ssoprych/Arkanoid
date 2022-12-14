using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingBrick2 : MonoBehaviour
{
    [SerializeField] public Sprite[] _bricks;
    public SpriteRenderer spriteRenderer;
    private static int t = 0;
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        spriteRenderer.sprite = _bricks[t];
        t++;
        if (t==3)
        {
            Destroy(gameObject);
            Arkanoid.score += 300;
            t = 0;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
