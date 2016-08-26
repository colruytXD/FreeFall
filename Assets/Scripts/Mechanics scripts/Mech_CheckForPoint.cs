using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Mech_CheckForPoint : MonoBehaviour {

    private Mech_Master mechMaster;

    void OnEnable()
    {
        SetInitialReferences();
    }

    void SetInitialReferences()
    {
        mechMaster = GameObject.FindGameObjectWithTag("GameHandler").GetComponent<Mech_Master>();
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.transform.CompareTag("Player"))
        {
            mechMaster.CallEventPointIncrease();
        }
    }
}
