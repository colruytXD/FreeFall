using UnityEngine;
using System.Collections;

public class GameManager_Master : MonoBehaviour {

    public delegate void GeneralEventHandler();

    public event GeneralEventHandler EventPlayerDie;
    public event GeneralEventHandler EventRestartLevel;
    public event GeneralEventHandler EventGoToMainMenu;
    public event GeneralEventHandler EventTogglePause;
    public event GeneralEventHandler EventGoToGameScene;
    public event GeneralEventHandler EventToggleMusic;

    public void CallEventPlayerDie()
    {
        if(EventPlayerDie != null)
        {
            EventPlayerDie();
        } 
    }

    public void CallEventRestartLevel()
    {
        if(EventRestartLevel != null)
        {
            EventRestartLevel();
        }
    }

    public void CallEventGoToMainMenu()
    {
        if(EventGoToMainMenu != null)
        {
            EventGoToMainMenu();
        }
    }

    public void CallEventTogglePause()
    {
        if(EventTogglePause != null)
        {
            EventTogglePause();
        }
    }

    public void CallEventGoToGameScene()
    {
        if(EventGoToGameScene != null)
        {
            EventGoToGameScene();
        }
    }

    public void CallEventToggleMusic()
    {
        if(EventToggleMusic != null)
        {
            EventToggleMusic();
        }
    }
}
