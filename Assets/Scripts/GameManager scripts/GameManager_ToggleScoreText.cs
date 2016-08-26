using UnityEngine;
using System.Collections;

public class GameManager_ToggleScoreText : MonoBehaviour {

    private GameManager_Master gameManagerMaster;

    [SerializeField]
    private GameObject txtScore, txtHighScore;

    void OnEnable()
    {
        SetInitialReferences();
        gameManagerMaster.EventTogglePause += ToggleScoreText;
        gameManagerMaster.EventPlayerDie += ToggleScoreText;
    }

    void OnDisable()
    {
        gameManagerMaster.EventTogglePause -= ToggleScoreText;
        gameManagerMaster.EventPlayerDie -= ToggleScoreText;
    }

    void SetInitialReferences()
    {
        gameManagerMaster = GetComponent<GameManager_Master>();
    }

    void ToggleScoreText()
    {
        txtScore.SetActive(!txtScore.activeSelf);
    }
}
