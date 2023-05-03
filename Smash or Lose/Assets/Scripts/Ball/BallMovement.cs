using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D rb2;

    private void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
          float randomRange = Random.Range(0f, 2f);
        if (randomRange <= 0.5f)
        {
            rb2.AddForce(new Vector2(80, 10));
        }
        else
        {
            rb2.AddForce(new Vector2(-80, -10));
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("...");
            rb2.velocity = new Vector2(rb2.velocity.x, rb2.velocity.y / 2 + collision.collider.GetComponent<Rigidbody2D>().velocity.y / 3);
        }
    }
}
