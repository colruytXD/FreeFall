using UnityEngine;
using System.Collections;

public class MapGen_RandomColor : MonoBehaviour {
   
	void OnEnable() 
	{
        GiveRandomColor();
	}

    void GiveRandomColor()
    {
        GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1f);
    }
}
