using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class GameManager_MenuBlur : MonoBehaviour {

    [SerializeField]
    private GameObject _camera;

	void OnEnable() 
	{
        _camera.GetComponent<Blur>().enabled = true;
        _camera.GetComponent<VignetteAndChromaticAberration>().enabled = true;
	}

	void OnDisable() 
	{
        _camera.GetComponent<Blur>().enabled = false;
        _camera.GetComponent<VignetteAndChromaticAberration>().enabled = false;
    }
}
