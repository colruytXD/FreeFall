using UnityEngine;
using System.Collections;

public class GameManager_SetupApp : MonoBehaviour {

	void OnEnable() 
	{
        Setup();
	}

    void Setup()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
}
