using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupManager : MonoBehaviour
{
    [Header("Settings Popup")]
    [SerializeField] private GameObject settingsPopup;
    [SerializeField] private Animator settingsAnimator;

    [Header("Level Complete")]
    [SerializeField] private GameObject levelComplete;
    [SerializeField] private Animator levelCompleteAnimator;

    void Start()
    {
        // Make sure the popup is inactive at startup
        if (settingsPopup != null)
        {
            settingsPopup.SetActive(false);
        }
        else if (levelComplete != null)
        {
            levelComplete.SetActive(false);
        }
    }

    // Function to display the popup (call from the Main Menu button)
    public void ShowSettingsPopup()
    {
        if (settingsPopup != null)
        {
            settingsPopup.SetActive(true);

            if (settingsAnimator != null)
            {
                settingsAnimator.SetTrigger("ShowPopup");
            }
        }
    }

    // Function to hide the popup (call from the X button on the popup)
    public void HideSettingsPopup()
    {
        if (settingsAnimator != null)
        {
            settingsAnimator.SetTrigger("HidePopup");
        }

        // The popup will be disabled after the animation
    }

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
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupManager : MonoBehaviour
{
    [Header("Settings Popup")]
    [SerializeField] private GameObject settingsPopup;
    [SerializeField] private Animator settingsAnimator;

    void Start()
    {
        // Make sure the popup is inactive at startup
        if (settingsPopup != null)
        {
            settingsPopup.SetActive(false);
        }
    }

    // Function to display the popup (call from the Main Menu button)
    public void ShowSettingsPopup()
    {
        if (settingsPopup != null)
        {
            settingsPopup.SetActive(true);

            if (settingsAnimator != null)
            {
                settingsAnimator.SetTrigger("ShowPopup");
            }
        }
    }

    // Function to hide the popup (call from the X button on the popup)
    public void HideSettingsPopup()
    {
        if (settingsAnimator != null)
        {
            settingsAnimator.SetTrigger("HidePopup");
        }

        // The popup will be disabled after the animation
    }
}
*/