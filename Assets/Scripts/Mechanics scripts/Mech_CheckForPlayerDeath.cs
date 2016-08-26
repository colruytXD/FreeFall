using UnityEngine;
using System.Collections;

public class Mech_CheckForPlayerDeath : MonoBehaviour {

    private GameManager_Master gameManagerMaster;

	void OnEnable() 
	{
		SetInitialReferences();
	}

	void SetInitialReferences() 
	{
        gameManagerMaster = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager_Master>();
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.transform.CompareTag("Killer"))
        {
            gameManagerMaster.CallEventPlayerDie();
        }
    }

}
