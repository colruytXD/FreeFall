using UnityEngine;
using System.Collections;

public class Mech_Master : MonoBehaviour {

    public delegate void GeneralEventHandler();

    public event GeneralEventHandler EventPointIncrease;

    public void CallEventPointIncrease()
    {
        if(EventPointIncrease != null)
        {
            EventPointIncrease();
        }
    }
}
