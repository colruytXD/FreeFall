using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;

public class Generate_Platforms : MonoBehaviour {

    [SerializeField]
    private Transform platform, platformPoint;
    [SerializeField]
    private Vector3[] spawnPositions;
    [SerializeField]
    private Vector3 distanceBetweenPlatform;

    [SerializeField]
    private int maxPlatformAmount, minPlatformAmount, amountOfPlatformsToSpawn;
    private int platformsSpawned;

    void OnEnable() 
	{
        GeneratePlatform();
	}

    public void GeneratePlatform()
    { 
        bool[] bools = new bool[maxPlatformAmount];
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

        //Checks if there aren't too many platform spawn instructions
        while (trueCount >= maxPlatformAmount)
        {         
                int rand = Random.Range(0, bools.Length);
                if (bools[rand] == true)
                {
                    bools[rand] = false;
                    trueCount--;
                }
        }     

        //Checks if there are enough platforms
        while (falseCount >= minPlatformAmount)
        {
            int rand = Random.Range(0, bools.Length);
            if(bools[rand]== false)
            {
                bools[rand] = true;
                falseCount--;
            }
        }


        //Spawns the platform or pointPlatform
        for(int i = 0; i < bools.Length; i++)
        {
            if(bools[i] == true)
            {
                Instantiate(platform, spawnPositions[i] + distanceBetweenPlatform * platformsSpawned, Quaternion.identity);
            }
            else
            {
                Instantiate(platformPoint, spawnPositions[i] + distanceBetweenPlatform * platformsSpawned, Quaternion.identity);
            }
        }

        platformsSpawned++;

        //Spawns as long the amount of spawned isn't over limit
        if(platformsSpawned < amountOfPlatformsToSpawn)
        {
            GeneratePlatform();
        }
    }
}
