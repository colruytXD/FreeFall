using UnityEngine;
using System.Collections;

public class GameManager_TogglePlayerControls : MonoBehaviour {

    private GameManager_Master gameManagerMaster;

    private GameObject player;

    bool isControllable = true;

	void OnEnable() 
	{
		SetInitialReferences();
        gameManagerMaster.EventPlayerDie += TogglePlayerControls;
        gameManagerMaster.EventTogglePause += TogglePlayerControls;
	}

	void OnDisable() 
	{
        gameManagerMaster.EventPlayerDie -= TogglePlayerControls;
        gameManagerMaster.EventTogglePause -= TogglePlayerControls;
    }

	void SetInitialReferences() 
	{
        gameManagerMaster = GetComponent<GameManager_Master>();
        player = GameObject.FindGameObjectWithTag("Player");

	}

    void TogglePlayerControls()
    {
        isControllable = !isControllable;

        if (isControllable)
        {
            player.GetComponent<PlayerController>().enabled = true;
            player.GetComponent<Mech_CheckForPlayerDeath>().enabled = true;
        }
        else
        {
            player.GetComponent<PlayerController>().enabled = false;
            player.GetComponent<Mech_CheckForPlayerDeath>().enabled = false;
        }
    }
}
