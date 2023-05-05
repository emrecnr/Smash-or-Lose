using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public  GameObject uiPanel;
    public TextMeshProUGUI countdownText;
    public float timeLeft = 90f;


    private void FixedUpdate()
    {
        countdownText.text = "Time Left:" + Mathf.Round(timeLeft).ToString() + "seconds";
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            uiPanel.SetActive(true);
            Time.timeScale = 0f;
            if (ScoreControl.playerScore > ScoreControl.aiScore)
            {
                Debug.Log("Win Player!");
            }
            else
            {
                Debug.Log("Win AI");
            }
        }
    }


}
