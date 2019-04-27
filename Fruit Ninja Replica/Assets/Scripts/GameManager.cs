using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text timer;
    public static float timeLeft;
    public Text userScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        timer.text = "Timer: " + timeLeft.ToString("00") + " Seconds";

        if (timeLeft < 0)
        {
            SceneManager.LoadScene("QuitScene");
        }

        userScore.text = "Your final score is: " + ScoreManager.userScore.ToString();
    }

    public void ChangeScene(string newSceneName)
    {
        SceneManager.LoadScene(newSceneName);
    }
}
