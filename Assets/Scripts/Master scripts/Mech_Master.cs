using UnityEngine;
using System.Collections;

public class Mech_Master : MonoBehaviour {

    public delegate void GeneralEventHandler();

    public event GeneralEventHandler EventPointIncrease;
    public event GeneralEventHandler EventCheckForNewHighscore;

    public void CallEventPointIncrease()
    {
        if(EventPointIncrease != null)
        {
            EventPointIncrease();
        }
    }

    public void CallEventCheckForNewHighscore()
    {
        if(EventCheckForNewHighscore != null)
        {
            EventCheckForNewHighscore();
        }
    }
}
