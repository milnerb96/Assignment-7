using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Text displayScore;
    public static int userScore = 0;
    public Text displayLives;
    public static int userLives = 3;


    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "GameOverScene")
        {
            displayScore.text = "Your Final Score is: " + userScore.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        displayScore.text = "Score: " + userScore.ToString();
        displayLives.text = "Lives: " + userLives.ToString();
    }

}
