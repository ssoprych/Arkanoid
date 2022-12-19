using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 100.0f;
    [SerializeField] private Rigidbody2D _ball;

    void Start()
    {
        _ball.velocity = Vector2.down * _speed;
        FindObjectOfType<GameManager>().BallCount++;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Paddle")
        {
            float x = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.x);

            Vector2 dir = new Vector2(x, 1).normalized;

            _ball.velocity = dir * _speed;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Floor"))
        {
            FindObjectOfType<GameManager>().BallCount--;
            Destroy(gameObject);
        }
    }
    float hitFactor(Vector2 ballPos, Vector2 paddlePos, float paddleWidth)
    {
        return (ballPos.x - paddlePos.x) / paddleWidth;
    }

}
