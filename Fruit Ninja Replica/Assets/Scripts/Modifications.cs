using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Modifications : MonoBehaviour
{
    public Dropdown melonSize;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (melonSize.value == 0)
        {
            FruitSpawner.scale = .5f;
        }

        if (melonSize.value == 1)
        {
            FruitSpawner.scale = 1f;
        }

        if (melonSize.value == 2)
        {
            FruitSpawner.scale = 1.75f;
        }
    }
}
