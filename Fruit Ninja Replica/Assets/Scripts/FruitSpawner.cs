using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour {

	public GameObject fruitPrefab;
	public Transform[] spawnPoints;
    public int numDestroyed = 3;
    public static float scale;

	public static float minDelay = .1f;
	public static float maxDelay = 1f;


    //public Vector2 widthThresold;
    //public Vector2 heightThresold;

    // Use this for initialization
    void Start () {
		StartCoroutine(SpawnFruits());
	}

    void Update()
    {

    }


    public void ScaleMelon()
    {
        fruitPrefab.transform.localScale = new Vector3(scale, scale, scale);
    }

    IEnumerator SpawnFruits ()
	{
		while (true)
		{
			float delay = Random.Range(minDelay, maxDelay);
			yield return new WaitForSeconds(delay);

			int spawnIndex = Random.Range(0, spawnPoints.Length);
			Transform spawnPoint = spawnPoints[spawnIndex];

            //ScaleMelon();
			GameObject spawnedFruit = Instantiate(fruitPrefab, spawnPoint.position, spawnPoint.rotation);
            Debug.Log(spawnedFruit.transform.position);

            //if (spawnedFruit.transform.position.x < -2.5f || spawnedFruit.transform.position.x > 2.5) 
            //{
            //    Destroy(spawnedFruit, 5f);
            //    ScoreManager.userLives -= 1;
            //}

            Destroy(spawnedFruit, 5f);

        }
	}

}
