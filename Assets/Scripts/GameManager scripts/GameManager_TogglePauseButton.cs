using UnityEngine;
using System.Collections;

public class GameManager_TogglePauseButton : MonoBehaviour {

    private GameManager_Master gameManagerMaster;

    [SerializeField]
    private GameObject pauseButton;

    void OnEnable()
    {
        SetInitialReferences();
        gameManagerMaster.EventTogglePause += TogglePauseButton; ;
        gameManagerMaster.EventPlayerDie += TogglePauseButton;
    }

    void OnDisable()
    {
        gameManagerMaster.EventTogglePause -= TogglePauseButton;
        gameManagerMaster.EventPlayerDie += TogglePauseButton;
    }

    void SetInitialReferences()
    {
        gameManagerMaster = GetComponent<GameManager_Master>();
    }

    void TogglePauseButton()
    {
        pauseButton.SetActive(!pauseButton.activeSelf);
    }
}
