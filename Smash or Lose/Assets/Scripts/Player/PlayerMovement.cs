using System.Collections;
using System.Collections.Generic;
using UnityEditor.AnimatedValues;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb2;

    [SerializeField] private GameObject ball;

    public bool isAI;

    private Vector2 playerMove;


    private void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (isAI)
        {
            AIControl();   
        }
        else 
        {
            PlayerControl();
        }
        
    }
    private void FixedUpdate()
    {
        rb2.velocity = playerMove*speed;
    }
    private void PlayerControl()
    {
        
        playerMove = new Vector2(0,Input.GetAxisRaw("Vertical"));
    }
    private void AIControl()
    {
        if(ball.transform.position.y> transform.position.y+0.5f)
        {
            playerMove = new Vector2(0, 1);
        }
        else if (ball.transform.position.y<transform.position.y-0.5f)
        {
            playerMove = new Vector2(0, -1);
        }
        else
        {
            playerMove = new Vector2(0,0);
        }
    }
}
