using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public GameObject PowerUp;
    private int _ballhits;
    public int _hitsToKill;
    public int _points;
    private static int i;
    public SpriteRenderer spriteRenderer;
    [SerializeField] public Sprite[] _bricks;
    private void Start()
    {
        _ballhits = 0;
        i = 0;
    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Ball")
        {
            _ballhits++;
            if (_ballhits == _hitsToKill)
            {
                Destroy(gameObject);
            }
            if (spriteRenderer)
            {
                i++;
                spriteRenderer.sprite = _bricks[i];
            }
            if (PowerUp)
            {
                Instantiate(PowerUp, transform.position, transform.rotation);
            }
        }
      
    }

}
