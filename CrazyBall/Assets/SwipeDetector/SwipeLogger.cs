using UnityEngine;

public class SwipeLogger : MonoBehaviour
{
    PlayerController playerController;


    private void Awake()
    {
        playerController = FindObjectOfType<PlayerController>();
        SwipeDetector.OnSwipe += SwipeDetector_OnSwipe;
    }

    private void SwipeDetector_OnSwipe(SwipeData data)
    {

        //GameManager.instance.PauseGame();

        //Debug.Log("Swipe in Direction: " + data.Direction);
        switch(data.Direction){
            case SwipeDirection.Up:
                playerController.SwipeUp();
                break;
            case SwipeDirection.Right:
                playerController.SwipeRight();
                break;
            case SwipeDirection.Left:
                playerController.SwipeLeft();
                break;
            default:

                break;
        }
    }
}