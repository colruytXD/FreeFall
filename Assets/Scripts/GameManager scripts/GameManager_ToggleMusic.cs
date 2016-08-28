using UnityEngine;
using System.Collections;

public class GameManager_ToggleMusic : MonoBehaviour {

    private GameManager_Master gameManagerMaster;

    [SerializeField]
    private GameObject musicSource;

	void OnEnable() 
	{
		SetInitialReferences();
        gameManagerMaster.EventToggleMusic += ToggleSound;
	}

	void OnDisable() 
	{
        gameManagerMaster.EventToggleMusic += ToggleSound;
    }

	void SetInitialReferences() 
	{
        gameManagerMaster = GetComponent<GameManager_Master>();
	}

    void ToggleSound()
    {
        musicSource.SetActive(!musicSource.activeSelf);
    }
}
