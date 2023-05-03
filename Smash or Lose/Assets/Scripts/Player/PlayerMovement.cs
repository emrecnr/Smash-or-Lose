using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb2;

    private void FixedUpdate()
    {
        float moveInput = Input.GetAxis("Vertical");
        rb2.velocity = new Vector2(0, moveInput*speed);
    }
}
