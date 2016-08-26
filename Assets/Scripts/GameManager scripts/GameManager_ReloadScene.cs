using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager_ReloadScene : MonoBehaviour {

    private GameManager_Master gameManagerMaster;

	void OnEnable() 
	{
		SetInitialReferences();
        gameManagerMaster.EventRestartLevel += ReloadScene;
	}

	void OnDisable() 
	{
        gameManagerMaster.EventRestartLevel -= ReloadScene;
    }

	void SetInitialReferences() 
	{
        gameManagerMaster = GetComponent<GameManager_Master>();
	}

    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
