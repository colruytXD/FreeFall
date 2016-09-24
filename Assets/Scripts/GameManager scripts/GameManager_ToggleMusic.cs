using UnityEngine;
using System.Collections;

public class GameManager_ToggleMusic : MonoBehaviour {

    private GameManager_Master gameManagerMaster;

	void OnEnable() 
	{
		SetInitialReferences();
        gameManagerMaster.EventToggleMusic += ToggleSound;
	}

	void OnDisable() 
	{
        gameManagerMaster.EventToggleMusic += ToggleSound;
    }

	void SetInitialReferences() 
	{
        gameManagerMaster = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager_Master>();
	}

    void ToggleSound()
    {
        GetComponent<AudioSource>().enabled = !GetComponent<AudioSource>().enabled;
    }
}
