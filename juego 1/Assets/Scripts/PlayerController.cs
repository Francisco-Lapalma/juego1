using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float playerSpeed = 3f;
    [SerializeField] float playerJumpSpeed = 3f;
    Rigidbody2D rb2D;



    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb2D.velocity = new Vector2(playerSpeed, rb2D.velocity.y);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb2D.velocity = new Vector2(-playerSpeed, rb2D.velocity.y);
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.W) && PlayerCollisions.isGrounded == true)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, playerJumpSpeed);
        }
    }
}
