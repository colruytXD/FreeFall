using UnityEngine;
using System.Collections;

public class Generate_DuplicateWall : MonoBehaviour {

    private Transform wall;

    void OnEnable()
    {
        wall = transform;
        //GenerateWalls();
    }

    void Start()
    {
        GenerateWalls();
    }

    void GenerateWalls()
    {
        if(transform.position.y < 10000)
        {

            Instantiate(wall, transform.position + new Vector3(0, 3, 0), transform.rotation);
        }
    }
}
