using UnityEngine;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoad_Highscore : MonoBehaviour {

    private GameManager_Master gameManagerMaster;
    private Mech_CheckHighscore highscoreScript;

	void OnEnable() 
	{
		SetInitialReferences();
        Load();
        gameManagerMaster.EventPlayerDie += Save;
        gameManagerMaster.EventRestartLevel += Save;
        gameManagerMaster.EventTogglePause += Save;
	}

	void OnDisable() 
	{
        gameManagerMaster.EventPlayerDie -= Save;
        gameManagerMaster.EventRestartLevel -= Save;
        gameManagerMaster.EventTogglePause -= Save;
    }

	void SetInitialReferences() 
	{
        gameManagerMaster = GetComponent<GameManager_Master>();
        highscoreScript = GetComponent<Mech_CheckHighscore>();
	}

    void Save()
    {
        FileStream file = File.Create(Application.persistentDataPath + "/Highscore.dat");
        BinaryFormatter bf = new BinaryFormatter();

        SaveAble_Highscore saveAbleHighscoreData = new SaveAble_Highscore();
        saveAbleHighscoreData.Highscore = highscoreScript.Highscore;

        bf.Serialize(file, saveAbleHighscoreData);
        file.Close();
    }

    void Load()
    {
        if(File.Exists(Application.persistentDataPath + "/Highscore.dat"))
        {
            FileStream file = File.Open(Application.persistentDataPath+ "/Highscore.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            SaveAble_Highscore saveAbleHighscoreData = new SaveAble_Highscore();
            saveAbleHighscoreData = (SaveAble_Highscore)bf.Deserialize(file);
            highscoreScript.Highscore = saveAbleHighscoreData.Highscore;

            file.Close();
        } 
        else
        {
            print("creating new save file");
            Save();
        }
        
    }
}

[System.Serializable]
public class SaveAble_Highscore
{
    public int Highscore;
}

