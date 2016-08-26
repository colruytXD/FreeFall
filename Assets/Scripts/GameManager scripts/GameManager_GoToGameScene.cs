using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager_GoToGameScene : MonoBehaviour {

    private GameManager_Master gameManagerMaster;

    [SerializeField]
    private int sceneToLoad;

	void OnEnable() 
	{
		SetInitialReferences();
        gameManagerMaster.EventGoToGameScene += GoToGameScene;
	}

	void OnDisable() 
	{
        gameManagerMaster.EventGoToGameScene -= GoToGameScene;
    }

	void SetInitialReferences() 
	{
        gameManagerMaster = GetComponent<GameManager_Master>();
	}

    void GoToGameScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
