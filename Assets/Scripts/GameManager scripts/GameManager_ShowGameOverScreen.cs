using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager_ShowGameOverScreen : MonoBehaviour {

    private GameManager_Master gameManagerMaster;

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
        //TODO: Add mechanic
        Debug.Log("Diededed");
        SceneManager.LoadScene(0);
    }
}
