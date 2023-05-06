using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D rb2;
    private int scoreAmount= 1;
    
    [SerializeField]private int hitCounter;
    [SerializeField] private float  initialSpeed=10;
    [SerializeField] private float speedIncrease =0.25f;


    private void Start()
    {
        
        rb2 = GetComponent<Rigidbody2D>();

        BallStartPos();

    }
    private void FixedUpdate()
    {
        rb2.velocity = Vector2.ClampMagnitude(rb2.velocity, initialSpeed+(speedIncrease*hitCounter));  
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player"||collision.gameObject.tag=="AI")
        {
            PlayerBounce(collision.transform);
        }
      
        if (collision.gameObject.tag =="Player Wall")
        {
            Debug.Log("Score Computer");
            ScoreControl.aiScore += scoreAmount;
            ResetPosition();
            
        }
        if(collision.gameObject.tag =="AI Wall")
        {
            Debug.Log("Score Player!!");
            ScoreControl.playerScore +=scoreAmount;
            ResetPosition();
        }
    }
    public void BallStartPos()
    {
        
        rb2.velocity = new Vector2(-1, 0) * (initialSpeed + speedIncrease * hitCounter);
        
    }
    public void ResetPosition()
    {
        rb2.velocity = new Vector2 (0,0);
        transform.position = new Vector2(0, 0);
        hitCounter = 0;
        Invoke("BallStartPos",2f);
    }
  
    public void PlayerBounce(Transform myObject)
    {
        hitCounter++;
        Vector2 ballPos = transform.position;
        Vector2 playerPos = myObject.position;

        float xDirection,yDirection;
        if (transform.position.x>0)
        {
            xDirection = -1;

        }
        else
        {
            xDirection = 1;
        }
        yDirection = (ballPos.y - playerPos.y) / myObject.GetComponent<Collider2D>().bounds.size.y;
        if (yDirection==0)
        {
            yDirection = 0.25f;
        }
        rb2.velocity = new Vector2(xDirection, yDirection) * (initialSpeed + (speedIncrease * hitCounter));
    }
    

}
