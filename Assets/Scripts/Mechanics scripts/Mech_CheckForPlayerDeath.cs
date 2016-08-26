using UnityEngine;
using System.Collections;

public class Mech_CheckForPlayerDeath : MonoBehaviour {

    private GameManager_Master gameManagerMaster;

    private Rigidbody rb;
    private Vector3 lastPos;

	void OnEnable() 
	{
		SetInitialReferences();
	}
	
	void FixedUpdate () 
	{
	    if(transform.position == lastPos)
        {
            gameManagerMaster.CallEventPlayerDie();
        }
        lastPos = transform.position;
    }

	void SetInitialReferences() 
	{
        rb = GetComponent<Rigidbody>();
        gameManagerMaster = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager_Master>();
    }

}
