using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupAnimationEvents : MonoBehaviour
{
    [SerializeField] private GameObject popupToDeactivate;

    void Start()
    {
        // If you don't assign anything, it will use the same GameObject
        if (popupToDeactivate == null)
        {
            popupToDeactivate = gameObject;
        }
    }

    // Function to call at the end of the Hide animation
    public void OnHideAnimationComplete()
    {
        popupToDeactivate.SetActive(false);
    }
}