using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    private int amountToMove = 3;

    [SerializeField]
    private int maxAmtOfXPos, maxAmtOfZPos, maxAmtOfXNeg, maxAmtOfZNeg;
    private int currentX, currentZ;

    public float acceleratorMultiplier;
	
    void FixedUpdate()
    {
        MoveDown();
    }

	void Update () 
	{
        //TEMP
        if (Input.GetKeyDown(KeyCode.Z))
        {
            MovePosX();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            MoveMinX();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            MovePosZ();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            MoveMinZ();
        }

        CheckInput();
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
        Vector3 to = transform.position -= new Vector3(0, .2f + acceleratorMultiplier, 0);

        transform.position = Vector3.Lerp(from, to, 100);
    }

    private float fingerStartTime = 0.0f;
    private Vector2 fingerStartPos = Vector2.zero;

    private bool isSwipe = false;
    private float minSwipeDist = 50.0f;
    private float maxSwipeTime = 0.5f;


    // Update is called once per frame
    void CheckInput()
    {

        if (Input.touchCount > 0)
        {

            foreach (Touch touch in Input.touches)
            {
                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        /* this is a new touch */
                        isSwipe = true;
                        fingerStartTime = Time.time;
                        fingerStartPos = touch.position;
                        break;

                    case TouchPhase.Canceled:
                        /* The touch is being canceled */
                        isSwipe = false;
                        break;

                    case TouchPhase.Ended:

                        float gestureTime = Time.time - fingerStartTime;
                        float gestureDist = (touch.position - fingerStartPos).magnitude;

                        if (isSwipe && gestureTime < maxSwipeTime && gestureDist > minSwipeDist)
                        {
                            Vector2 direction = touch.position - fingerStartPos;
                            Vector2 swipeType = Vector2.zero;

                            if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
                            {
                                // the swipe is horizontal:
                                swipeType = Vector2.right * Mathf.Sign(direction.x);
                            }
                            else {
                                // the swipe is vertical:
                                swipeType = Vector2.up * Mathf.Sign(direction.y);
                            }

                            if (swipeType.x != 0.0f)
                            {
                                if (swipeType.x > 0.0f)
                                {
                                    MoveMinZ();
                                }
                                else {
                                    MovePosZ();
                                }
                            }

                            if (swipeType.y != 0.0f)
                            {
                                if (swipeType.y > 0.0f)
                                {
                                    MovePosX();
                                }
                                else {
                                    MoveMinX();
                                }
                            }

                        }

                        break;
                }
            }
        }

    }
}
