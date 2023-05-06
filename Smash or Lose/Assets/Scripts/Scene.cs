using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void Retry()
    {
        Time.timeScale = 1f;
        ScoreControl.ResetScore();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Quit()
    {
        Debug.Log("Quit App");
        Application.Quit();
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
