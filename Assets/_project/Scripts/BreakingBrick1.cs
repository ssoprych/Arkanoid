using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingBrick1 : MonoBehaviour
{
    [SerializeField] public Sprite[] _bricks;
    public SpriteRenderer spriteRenderer;
    private static int j = 0;
    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        spriteRenderer.sprite = _bricks[j];
        j++;
        if (j == 2)
        {
            Destroy(gameObject);
            Arkanoid.score += 200;
            j = 0;
        }

    }

}
