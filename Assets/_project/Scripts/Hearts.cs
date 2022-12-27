using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearts : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] Heart;
    private int i;
    void Update()
    {
        i = FindObjectOfType<GameManager>().Health;
        spriteRenderer.sprite = Heart[i];
    }
}
