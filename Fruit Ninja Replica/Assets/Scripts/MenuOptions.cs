using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuOptions : MonoBehaviour
{
    public Dropdown melonSpeed;
    public Dropdown timerSelection;

    void Update()
    {
        if (melonSpeed.value == 0)
        {
            FruitSpawner.minDelay = 1f;
            FruitSpawner.maxDelay = 1.5f;
        }

        if (melonSpeed.value == 1)
        {
            FruitSpawner.minDelay = .7f;
            FruitSpawner.maxDelay = 1f;
        }

        if (melonSpeed.value == 2)
        {
            FruitSpawner.minDelay = .1f;
            FruitSpawner.maxDelay = .7f;
        }

        if (timerSelection.value == 0)
        {
            GameManager.timeLeft = 30f;
        }

        if (timerSelection.value == 1)
        {
            GameManager.timeLeft = 60f;
        }

        if (timerSelection.value == 2)
        {
            GameManager.timeLeft = 120f;
        }
    }
}
