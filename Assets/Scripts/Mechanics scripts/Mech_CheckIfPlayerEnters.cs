using UnityEngine;
using System.Collections;

public class Mech_CheckIfPlayerEnters : MonoBehaviour {

    private GameManager_Master gameManagerMaster;

	void OnEnable() 
	{
		SetInitialReferences();
	}

	void SetInitialReferences() 
	{
        gameManagerMaster = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager_Master>();
	}

    void OnTriggerEnter()
    {
        gameManagerMaster.CallEventPlayerDie();
    }

}
