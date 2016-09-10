using UnityEngine;
using System.Collections;

public class GameManager_SetupApp : MonoBehaviour {

	void Start() 
	{
        Setup();
	}

    void Setup()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.fullScreen = false;
    }
}
