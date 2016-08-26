using UnityEngine;
using System.Collections;

public class Generate_DuplicateWall : MonoBehaviour {

    [SerializeField]
    private Transform wall;

	void OnEnable() 
	{
		SetInitialReferences();
        GenerateWalls();
	}

	void OnDisable() 
	{

	}
	
	void Update () 
	{
	
	}

	void SetInitialReferences() 
	{

	}

    void GenerateWalls()
    {
        Instantiate(wall, transform.position + new Vector3(0, 3, 0), transform.rotation);
    }
}
