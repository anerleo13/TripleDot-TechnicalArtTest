using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimatedToggle : MonoBehaviour
{
    private Toggle toggle;
    private Animator toggleAnimator;

    void Start()
    {
        // Get components
        toggle = GetComponent<Toggle>();
        toggleAnimator = GetComponent<Animator>();

        // Listen for changes in the toggle
        toggle.onValueChanged.AddListener(OnToggleChanged);

        // Configure initial state
        InitializeToggleState();
    }

    void InitializeToggleState()
    {
        // Set the initial state without animation
        toggleAnimator.SetBool("IsOn", toggle.isOn);

        if (toggle.isOn)
        {
            toggleAnimator.Play("ToggleOn", 0, 1f);
        }
        else
        {
            toggleAnimator.Play("ToggleOff", 0, 1f);
        }
    }

    void OnToggleChanged(bool isOn)
    {
        // Update the bool to maintain the state
        toggleAnimator.SetBool("IsOn", isOn);

        // Trigger the corresponding animation
        if (isOn)
        {
            toggleAnimator.SetTrigger("TurnOn");
        }
        else
        {
            toggleAnimator.SetTrigger("TurnOff");
        }
    }

    void OnDestroy()
    {
        // Clean the listener
        if (toggle != null)
        {
            toggle.onValueChanged.RemoveListener(OnToggleChanged);
        }
    }
}
