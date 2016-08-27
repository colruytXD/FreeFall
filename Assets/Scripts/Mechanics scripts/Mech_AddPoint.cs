using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Mech_AddPoint : MonoBehaviour {

    private Mech_Master mechMaster;
    [SerializeField]
    private Text txtPoints;

    public int currentPoints;
    [SerializeField]
    private GameObject playerGo;
    private PlayerController playerController;

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
        playerController = playerGo.GetComponent<PlayerController>();
    }

    void AddPoint()
    {
        currentPoints += 1;
        txtPoints.text = currentPoints.ToString();
        playerController.acceleratorMultiplier += 0.003f;
    }
}
