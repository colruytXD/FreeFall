using UnityEngine;
using System.Collections;

public class GameManager_ToggleTimeScale : MonoBehaviour {

    private GameManager_Master gameManagerMaster;

	void OnEnable() 
	{
		SetInitialReferences();
        gameManagerMaster.EventTogglePause += ToggleTimeScale;
        gameManagerMaster.EventPlayerDie += ToggleTimeScale;
	}

	void OnDisable() 
	{
        gameManagerMaster.EventTogglePause -= ToggleTimeScale;
        gameManagerMaster.EventPlayerDie -= ToggleTimeScale;
    }

	void SetInitialReferences() 
	{
        gameManagerMaster = GetComponent<GameManager_Master>();
	}

    void ToggleTimeScale()
    {
        if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
