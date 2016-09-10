using UnityEngine;
using System.Collections;

public class GameManager_ToggleLoadingIcon : MonoBehaviour {

    private GameManager_Master gameManagerMaster;

    [SerializeField]
    private GameObject loadingIcon;

	void OnEnable() 
	{
		SetInitialReferences();
        gameManagerMaster.EventGoToGameScene += ToggleLoadingIcon;
        gameManagerMaster.EventGoToMainMenu += ToggleLoadingIcon;
	}

	void OnDisable() 
	{
        gameManagerMaster.EventGoToGameScene -= ToggleLoadingIcon;
        gameManagerMaster.EventGoToMainMenu -= ToggleLoadingIcon;
    }

	void SetInitialReferences() 
	{
        gameManagerMaster = GetComponent<GameManager_Master>();
	}

    void ToggleLoadingIcon()
    {
        loadingIcon.SetActive(!loadingIcon.activeSelf);
    }
}
