using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager_ToggleMusicIcon : MonoBehaviour {

    private GameManager_Master gameManagerMaster;

    [SerializeField]
    private Sprite imgSoundOn, imgSoundOff;
    [SerializeField]
    private Button btnToggleSound;

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
        gameManagerMaster = GetComponent<GameManager_Master>();
	}

    void ToggleMusicIcon()
    {
        soundOn = !soundOn;
        if(!soundOn)
        {
            btnToggleSound.image.sprite = imgSoundOff;
        }
        else
        {
            btnToggleSound.image.sprite = imgSoundOn;
        }
    }
}
