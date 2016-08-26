using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;

public class Generate_Platforms : MonoBehaviour {

    [SerializeField]
    private Transform platform;
    [SerializeField]
    private Vector3[] spawnPositions;
    [SerializeField]
    private Vector3 distanceBetweenPlatform;

    [SerializeField]
    private int maxPlatformAmount, minPlatformAmount, amountOfPlatformsToSpawn;
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

    public void GeneratePlatform()
    { 
        bool[] bools = new bool[maxPlatformAmount];


        //Generates an array of booleans

        //Make sure not 9 bools are true
        int trueCount = 0;
        int falseCount = 0;
        for (int i = 0; i < bools.Length; i++)
        {
            //Picks random number between 0 and 1. If less than half => false, if more then half => true
            if(Random.value > .5)
            {
                bools[i] = true;
                trueCount++;
            }
            else
            {
                bools[i] = false;
                falseCount++;
            }
        }
        while (trueCount >= maxPlatformAmount)
        {         
                int rand = Random.Range(0, bools.Length);
                if (bools[rand] == true)
                {
                    bools[rand] = false;
                    trueCount--;
                }
        }     

        while (falseCount >= minPlatformAmount)
        {
            int rand = Random.Range(0, bools.Length);
            if(bools[rand]== false)
            {
                bools[rand] = true;
                falseCount--;
            }
        }


        //Spawns the platform
        for(int i = 0; i < bools.Length; i++)
        {
            if(bools[i] == true)
            {
                Instantiate(platform, spawnPositions[i] + distanceBetweenPlatform * platformsSpawned, Quaternion.identity);
            }
        }

        platformsSpawned++;

        if(platformsSpawned < amountOfPlatformsToSpawn)
        {
            GeneratePlatform();
        }
    }
}
