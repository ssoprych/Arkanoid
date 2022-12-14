using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _paddleRb;
    public static int _speed = 2;
    void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        _paddleRb.velocity = Vector2.right * horizontal * _speed * Time.deltaTime * 1000;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
