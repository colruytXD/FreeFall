using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager_ShowGameOverScreen : MonoBehaviour {

    private GameManager_Master gameManagerMaster;

    [SerializeField]
    private GameObject gameOverUI;

	void OnEnable() 
	{
		SetInitialReferences();
        gameManagerMaster.EventPlayerDie += ShowGameOverScreen;
	}

	void OnDisable() 
	{
        gameManagerMaster.EventPlayerDie -= ShowGameOverScreen;
    }

	void SetInitialReferences() 
	{
        gameManagerMaster = GetComponent<GameManager_Master>();
	}

    void ShowGameOverScreen()
    {
        Debug.Log("Player died, showing Game over screen");
        gameOverUI.SetActive(true);
    }
}
