using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bird : MonoBehaviour
{
    private const float JUMP_VELOCITY = 7f;

    private Rigidbody2D rigidbodyBird;
   

    private void Awake()
    {
        rigidbodyBird = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {

    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rigidbodyBird.velocity = Vector2.up * JUMP_VELOCITY;
        }
    }

}
