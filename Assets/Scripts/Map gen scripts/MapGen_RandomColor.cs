using UnityEngine;
using System.Collections;

public class MapGen_RandomColor : MonoBehaviour {

    private Material myMat;

	void OnEnable() 
	{
		SetInitialReferences();
        GiveRandomColor();
	}

	void OnDisable() 
	{

	}
	
	void Update () 
	{
	
	}

	void SetInitialReferences() 
	{
        myMat = GetComponent<Material>();
	}

    void GiveRandomColor()
    {
        GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1);
    }
}
