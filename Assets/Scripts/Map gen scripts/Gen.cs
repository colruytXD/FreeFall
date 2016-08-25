using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;

public class Gen : MonoBehaviour {

    [SerializeField]
    private Transform platform;
    [SerializeField]
    private Vector3[] spawnPositions;
    [SerializeField]
    private Vector3 distanceBetweenPlatform;

    [SerializeField]
    private int maxPlatformAmount, minPlatformAmount;
    private int platformsSpawned;



    void OnEnable() 
	{
		SetInitialReferences();
        GeneratePlatform();
	}

	void OnDisable() 
	{

	}
	
	void Update () 
	{
	    if(Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene(0);
        }
	}

	void SetInitialReferences() 
	{

	}

    void GeneratePlatform()
    { 
        maxPlatformAmount = spawnPositions.Length;
        bool[] bools = new bool[maxPlatformAmount];

        //Generates an array of booleans
        for(int i = 0; i < bools.Length; i++)
        {
            float randomValue = Random.value;
            if(randomValue > .5)
            {
                bools[i] = true;
            }
            else
            {
                bools[i] = false;
            }
        }

        //Make sure not 9 bools are true
        int trueCount = 0 ;
        int falseCount = 0;

        for(int i = 0; i < bools.Length; i++)
        {
            if(bools[i] == true)
            {
                trueCount++;
            }
            if(bools[i] == false)
            {
                falseCount++;
            }
        }

        if(trueCount == maxPlatformAmount)
        {
            Debug.Log("Generated 9 floors, fixing...");
            bools[Random.Range(0, maxPlatformAmount)] = false;
        }

        //Spawns the platform
        for(int i = 0; i < spawnPositions.Length; i++)
        {
            if(bools[i])
            {
                Instantiate(platform, spawnPositions[i] + distanceBetweenPlatform * platformsSpawned, Quaternion.identity);
            }
        }

        platformsSpawned++;

        if(platformsSpawned < 100)
        {
            GeneratePlatform();
        }
    }
}
