using UnityEngine;
using System.Collections;

public class SaveLoad_MusicToggle : MonoBehaviour {

    private GameManager_Master gameManagerMaster;
    [SerializeField]
    private GameObject musicGo;
    private int isMusicEnabled; //1 is true, 0 is false

	void OnEnable() 
	{
		SetInitialReferences();
        gameManagerMaster.EventToggleMusic += Save;
        //Load();
	}

    void Start()
    {
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
        if(!musicGo.GetComponent<AudioSource>().enabled)
        {
            isMusicEnabled = 1;
        }
        else
        {
            isMusicEnabled = 0;
        }

        PlayerPrefs.SetInt("MusicEnabled", isMusicEnabled);
        Debug.Log("Saved: " + isMusicEnabled);
    }

    void Load()
    {
        isMusicEnabled = PlayerPrefs.GetInt("MusicEnabled");

        if(PlayerPrefs.GetInt("MusicEnabled") == 0)
        {
            gameManagerMaster.CallEventToggleMusic();
        }

        Debug.Log("Loaded: " + isMusicEnabled);
    }
}
