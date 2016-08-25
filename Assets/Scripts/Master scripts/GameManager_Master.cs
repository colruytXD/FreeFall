using UnityEngine;
using System.Collections;

public class GameManager_Master : MonoBehaviour {

    public delegate void GeneralEventHandler();

    public event GeneralEventHandler EventPlayerDie;

    public void CallEventPlayerDie()
    {
        if(EventPlayerDie != null)
        {
            EventPlayerDie();
        } 
    }
}
