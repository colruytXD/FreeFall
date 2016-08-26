using UnityEngine;
using System.Collections;

public class Generate_ColorSwitch : MonoBehaviour {

    public float timeBetweenSwitch = 1;

	void OnEnable() 
	{
        InvokeRepeating("SwitchColor", timeBetweenSwitch, timeBetweenSwitch);
	}

    void SwitchColor()
    {
        GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 0.5f);
    }
}
