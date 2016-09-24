using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager_ToggleMusicIcon : MonoBehaviour {

    private GameManager_Master gameManagerMaster;

    [SerializeField]
    private Sprite imgSoundOn, imgSoundOff;

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
            GetComponent<Button>().image.sprite = imgSoundOff;
        }
        else
        {
            GetComponent<Button>().image.sprite = imgSoundOn;
        }
    }
}
