using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FooterSwipeController : MonoBehaviour
{
    public Animator footerAnimator;
    public string showTrigger = "ShowFooter";
    public string hideTrigger = "HideFooter";

    private Vector2 startTouchPos;
    private bool isSwiping = false;
    private float swipeThreshold = 50f; // Minimum distance in pixels to detect swipe

    void Update()
    {
        // Touch (for mobile/tablets)
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (IsInBottomThird(touch.position))
            {
                HandleTouch(touch.phase, touch.position);
            }
        }
        // Mouse (for PC testing)
        else if (Input.GetMouseButtonDown(0))
        {
            if (IsInBottomThird(Input.mousePosition))
            {
                isSwiping = true;
                startTouchPos = Input.mousePosition;
            }
        }
        else if (Input.GetMouseButtonUp(0) && isSwiping)
        {
            isSwiping = false;
            Vector2 endPos = Input.mousePosition;
            HandleSwipe(endPos - startTouchPos);
        }
    }

    void HandleTouch(TouchPhase phase, Vector2 position)
    {
        if (phase == TouchPhase.Began)
        {
            startTouchPos = position;
        }
        else if (phase == TouchPhase.Ended)
        {
            Vector2 delta = position - startTouchPos;
            HandleSwipe(delta);
        }
    }

    void HandleSwipe(Vector2 delta)
    {
        if (Mathf.Abs(delta.y) > Mathf.Abs(delta.x) && Mathf.Abs(delta.y) > swipeThreshold)
        {
            if (delta.y > 0)
            {
                footerAnimator.SetTrigger(showTrigger);
                Debug.Log("Swipe up: showing footer");
            }
            else
            {
                footerAnimator.SetTrigger(hideTrigger);
                Debug.Log("Swipe down: hiding footer");
            }
        }
    }

    bool IsInBottomThird(Vector2 screenPosition)
    {
        return screenPosition.y <= Screen.height / 3f;
    }
}
