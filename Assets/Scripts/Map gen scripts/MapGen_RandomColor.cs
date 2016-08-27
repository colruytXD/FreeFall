using UnityEngine;
using System.Collections;

public class MapGen_RandomColor : MonoBehaviour {

    private Material myMat;

	void OnEnable() 
	{
		SetInitialReferences();
        GiveRandomColor();
	}

	void SetInitialReferences() 
	{
        myMat = GetComponent<Material>();
	}

    void GiveRandomColor()
    {
        //int i = Random.Range(0, 2);
        //if(i == 0)
        //{
        //    GetComponent<Renderer>().material.color = Color.black;
        //}
        //else
        //{
        //    GetComponent<Renderer>().material.color = Color.white;
        //}
        GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1f);
    }
}
