using UnityEngine;
using System.Collections;

public class SaveLoad_MusicToggle : MonoBehaviour {

    private GameManager_Master gameManagerMaster;
    [SerializeField]
    private AudioSource musicSource;
    private int isMusicEnabled; //1 is true, 0 is false

	void OnEnable() 
	{
		SetInitialReferences();
        gameManagerMaster.EventToggleMusic += Save;
        Load();
	}

	void OnDisable() 
	{
        gameManagerMaster.EventToggleMusic += Save;
    }

	void SetInitialReferences() 
	{
        gameManagerMaster = GetComponent<GameManager_Master>();
	}

    void Save()
    {
        if(musicSource.gameObject.activeSelf)
        {
            isMusicEnabled = 1;
        }
        else
        {
            isMusicEnabled = 0;
        }

        PlayerPrefs.SetInt("MusicEnabled", isMusicEnabled);
    }

    void Load()
    {
        isMusicEnabled = PlayerPrefs.GetInt("MusicEnabled");

        if(PlayerPrefs.GetInt("MusicEnabled") == 0)
        {
            gameManagerMaster.CallEventToggleMusic();
        }
    }
}
