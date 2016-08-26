using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager_ShowGameOverScreen : MonoBehaviour {

    private GameManager_Master gameManagerMaster;
    [SerializeField]
    private GameObject player,gen;
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
        player.transform.position = new Vector3(0, 1040, 0);
        gen.GetComponent<Generate_Platforms>().GeneratePlatform();

    }
}
