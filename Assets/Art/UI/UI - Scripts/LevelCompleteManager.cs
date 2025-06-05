using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleteManager : MonoBehaviour
{
    [Header("Level Complete")]
    [SerializeField] private GameObject levelComplete;
    [SerializeField] private Animator levelCompleteAnimator;

    void Start()
    {
        // Make sure the popup is inactive at startup
        if (levelComplete != null)
        {
            levelComplete.SetActive(false);
        }
    }

    // Function to display the popup (call from the Main Menu button)
    public void ShowLevelComplete()
    {
        if (levelComplete != null)
        {
            levelComplete.SetActive(true);

            if (levelCompleteAnimator != null)
            {
                levelCompleteAnimator.SetTrigger("ShowLevelComplete");
            }
        }
    }

    // Function to hide the popup (call from the X button on the popup)
    public void HideLevelComplete()
    {
        if (levelCompleteAnimator != null)
        {
            levelCompleteAnimator.SetTrigger("HideLevelComplete");
        }

        // The popup will be disabled after the animation
    }
}