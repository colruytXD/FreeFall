using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager_GoToMainMenu : MonoBehaviour {

    private GameManager_Master gameManagerMaster;

    public int sceneToLoad = 0;

	void OnEnable() 
	{
		SetInitialReferences();
        gameManagerMaster.EventGoToMainMenu += LoadScene;
	}

	void OnDisable() 
	{
        gameManagerMaster.EventGoToMainMenu -= LoadScene;
    }

	void SetInitialReferences() 
	{
        gameManagerMaster = GetComponent<GameManager_Master>();
	}

    void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
