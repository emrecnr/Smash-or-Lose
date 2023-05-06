using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public  GameObject uiPanel;
    public TextMeshProUGUI countdownText;
    public TextMeshProUGUI winText;
    private float timeLeft = 60f;
    public Color winColor;
    public Color loseColor;
    


    private void FixedUpdate()
    {
        
            countdownText.text = Mathf.Round(timeLeft).ToString();
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {

                uiPanel.SetActive(true);

                Time.timeScale = 0f;
                if (ScoreControl.playerScore > ScoreControl.aiScore)
                {
                    uiPanel.GetComponent<Image>().color = winColor;
                    Debug.Log("Win Player!");
                    winText.text = "WON PLAYER";
                }
                else if (ScoreControl.playerScore < ScoreControl.aiScore)
                {

                    uiPanel.GetComponent<Image>().color = loseColor;
                    Debug.Log("Won AÝ");
                    winText.text = "WON COMPUTER";
                }
                else
                {

                    Debug.Log("Draw");
                    winText.text = "DRAW";
                }
            }
       
        
    }

    

   



}
