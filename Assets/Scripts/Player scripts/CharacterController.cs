using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

    [SerializeField]
    private int amountToMove = 5;

    [SerializeField]
    private int maxAmtOfXPos, maxAmtOfZPos, maxAmtOfXNeg, maxAmtOfZNeg;
    private int currentX, currentZ;

	void OnEnable() 
	{
	}

	void OnDisable() 
	{

	}
	
    void FixedUpdate()
    {
        MoveDown();
    }

	void Update () 
	{

	    //TEMP
        if(Input.GetKeyDown(KeyCode.D))
        {
            MovePosX();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            MoveMinX();
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            MovePosZ();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            MoveMinZ();
        }
    }

    //Moves character on the x axis (Positive, +)
    public void MovePosX() 
    {
        if(currentX < maxAmtOfXPos)
        {
            transform.Translate(amountToMove, 0, 0, Space.Self);
            currentX++;
        }
        
    }

    //Moves character on the x axis (Negative, -)
    public void MoveMinX()
    {
        if(currentX > maxAmtOfXNeg)
        {
            transform.Translate(-amountToMove, 0, 0, Space.Self);
            currentX--;
        }
        
    }

    //Moves character on the z axis (Positive, +)
    public void MovePosZ()
    {
        if(currentZ < maxAmtOfZPos)
        {
            transform.Translate(0, 0, amountToMove, Space.Self);
            currentZ++;
        } 
    }

    //Moves character on the z axis (Negative, -)
    public void MoveMinZ()
    {
        if(currentZ > maxAmtOfZNeg)
        {
            transform.Translate(0, 0, -amountToMove, Space.Self);
            currentZ--;
        }
        
    }

    public void MoveDown()
    {
        Vector3 from = transform.position;
        Vector3 to = transform.position -= new Vector3(0, .4f, 0);

        transform.position = Vector3.Lerp(from, to, 100);
    }
}
