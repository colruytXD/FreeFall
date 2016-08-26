using UnityEngine;
using System.Collections;

public class Mech_CheckIfPlayerEnters : MonoBehaviour {

    private Mech_Master mechMaster;

	void OnEnable() 
	{
		SetInitialReferences();
	}

	void SetInitialReferences() 
	{
        mechMaster = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Mech_Master>();
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.transform.CompareTag("Player"))
        {
            mechMaster.CallEventPointIncrease();
        }
    }

}
