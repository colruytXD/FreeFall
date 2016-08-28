using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Mech_CheckHighscore : MonoBehaviour {

    private Mech_Master mechMaster;
    private GameManager_Master gameManagerMaster;
    private Mech_AddPoint pointScript;

    [SerializeField]
    private Text txtHighscoreEOG, txtScoreEOG; //EOG = End of game

    public int Highscore;

	void OnEnable() 
	{
		SetInitialReferences();
        mechMaster.EventCheckForNewHighscore += CheckForNewHighscore;
        gameManagerMaster.EventPlayerDie += DisplayScoresEOG;
    }

	void OnDisable() 
	{
        mechMaster.EventCheckForNewHighscore -= CheckForNewHighscore;
        gameManagerMaster.EventPlayerDie -= DisplayScoresEOG;
    }

	void SetInitialReferences() 
	{
        mechMaster = GetComponent<Mech_Master>();
        pointScript = GetComponent<Mech_AddPoint>();
        gameManagerMaster = GetComponent<GameManager_Master>();
	}

    void CheckForNewHighscore()
    {
        if(pointScript.currentPoints >= Highscore)
        {
            Highscore = pointScript.currentPoints;
        }
    }

    void DisplayScoresEOG()
    {
        txtHighscoreEOG.text = "Best: " + Highscore.ToString();
        txtScoreEOG.text = "Score: " + pointScript.currentPoints.ToString();
    }
}
