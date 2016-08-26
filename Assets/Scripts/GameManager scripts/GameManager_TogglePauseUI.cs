using UnityEngine;
using System.Collections;

public class GameManager_TogglePauseUI : MonoBehaviour {

    private GameManager_Master gameManagerMaster;

    [SerializeField]
    private GameObject pauseUI;

	void OnEnable() 
	{
		SetInitialReferences();
        gameManagerMaster.EventTogglePause += TogglePauseUI;
	}

	void OnDisable() 
	{
        gameManagerMaster.EventTogglePause -= TogglePauseUI;
    }

	void SetInitialReferences() 
	{
        gameManagerMaster = GetComponent<GameManager_Master>();
	}

    void TogglePauseUI()
    {
        pauseUI.SetActive(!pauseUI.activeSelf);
    }
}
