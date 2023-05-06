using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreControl : MonoBehaviour
{
     public bool isAI;
     public TextMeshProUGUI playerScoreText;
     public TextMeshProUGUI aiScoreText;
     public static int playerScore = 0;
     public static int aiScore = 0;
    



    void Start()
    {
        playerScoreText.text = playerScore.ToString();
        aiScoreText.text = aiScore.ToString();
    }

    
    void Update()
    {
       
        playerScoreText.text = playerScore.ToString();
        aiScoreText.text = aiScore.ToString();
        
    }
    public static void ResetScore()
    {
        playerScore = 0;
        aiScore = 0;
    }
    public void AddScore(int scoreAmount)
    {
            
    }

}
