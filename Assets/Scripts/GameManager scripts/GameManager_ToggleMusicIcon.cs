using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager_ToggleMusicIcon : MonoBehaviour {

    private GameManager_Master gameManagerMaster;

    [SerializeField]
    private Sprite imgSoundOn, imgSoundOff;
    [SerializeField]
    private Button btnToggleSound;

	void OnEnable() 
	{
		SetInitialReferences();
        gameManagerMaster.EventToggleMusic += CheckToggleMusicIcon;
	}

	void OnDisable() 
	{
        gameManagerMaster.EventToggleMusic -= CheckToggleMusicIcon;
    }

	void SetInitialReferences() 
	{
        gameManagerMaster = GetComponent<GameManager_Master>();
	}

    public void CheckToggleMusicIcon()
    {
        if(btnToggleSound.image.sprite == imgSoundOn)
        {
            btnToggleSound.image.sprite = imgSoundOff;
        }
        else
        {
            btnToggleSound.image.sprite = imgSoundOn;
        }
    }
}
