using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private Animator _anim;
    public GameObject Ball;
    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    [ContextMenu("IncreasePaddle")]
    private void IncreasePaddleSize()
    {
        //play animation
        _anim.SetBool("IsBig", true);
        //play sound
    }

    [ContextMenu("DecreasePaddle")]
    private void DecreasePaddleSize()
    {
        //play animation
        _anim.SetBool("IsBig", false);
        //play sound
    }
    //spawn ball from paddle
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "SizeUp(Clone)")
        {
            //increase paddle size 
            StartCoroutine(SizeUp());
            //destroy power up object 
            Destroy(collision.gameObject);
            //play sound
        }
        if (collision.gameObject.name == "SpeedUp(Clone)")
        {
            //increase paddle speed 
            Movement._speed += 2;
            //destroy power up object 
            Destroy(collision.gameObject);
            //play sound
        }
        if (collision.gameObject.name == "BallUp(Clone)")
        {
            //Spawn ball
            Instantiate(Ball, transform.position, transform.rotation);
            //destroy power up object 
            Destroy(collision.gameObject);
            //play sound
        }
    }
    private IEnumerator SizeUp()
    {
        IncreasePaddleSize();
        yield return new WaitForSeconds(5);
        DecreasePaddleSize();
    }
}
