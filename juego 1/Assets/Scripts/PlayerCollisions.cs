using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public static bool isGrounded;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
    }

    private void Update()
    {
        if (isGrounded == true)
        {
            Debug.Log("Player is grounded");
        }
        else
        {
            Debug.Log("Player is not grounded");
        }
    }
}
