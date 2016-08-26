using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Mech_AddPoint : MonoBehaviour {

    private Mech_Master mechMaster;
    [SerializeField]
    private Text txtPoints;

    public int currentPoints;

    void OnEnable()
    {
        SetInitialReferences();
        mechMaster.EventPointIncrease += AddPoint;
    }

    void OnDisable()
    {
        mechMaster.EventPointIncrease -= AddPoint;
    }

    void SetInitialReferences()
    {
        mechMaster = GetComponent<Mech_Master>();
    }

    void AddPoint()
    {
        currentPoints += 1;
        txtPoints.text = currentPoints.ToString();
    }
}
