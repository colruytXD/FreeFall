using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager_ToggleMusicIcon : MonoBehaviour {

    private GameManager_Master gameManagerMaster;

    [SerializeField]
    private Sprite imgSoundOn, imgSoundOff;
    [SerializeField]
    private Button musicButton;

    private bool soundOn = true;

	void OnEnable() 
	{
        SetInitialReferences();
        gameManagerMaster.EventToggleMusic += ToggleMusicIcon;
    }

	void OnDisable() 
	{
        gameManagerMaster.EventToggleMusic -= ToggleMusicIcon;
    }

	void SetInitialReferences() 
	{
        gameManagerMaster = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager_Master>();
	}

    void ToggleMusicIcon()
    {
        soundOn = !soundOn;
        if(!soundOn)
        {
            musicButton.image.sprite = imgSoundOff;
        }
        else
        {
            musicButton.image.sprite = imgSoundOn;
        }

        Debug.Log("Toggled sprite");
    }
}
