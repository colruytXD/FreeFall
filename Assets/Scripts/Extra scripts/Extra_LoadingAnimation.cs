using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Extra_LoadingAnimation : MonoBehaviour { 
	
	void Update () 
	{
        LoadAnimation();
	}

    void LoadAnimation()
    {
        transform.Rotate(0, 0, 2.5f);
    }
}
