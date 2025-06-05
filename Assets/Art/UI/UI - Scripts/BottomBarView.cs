using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomBarView : MonoBehaviour
{
    public Animator bottomBarAnimator;  // Assign animator

    [System.Serializable]
    public class StateMessagePair
    {
        public string stateName;  // Animation Label Name
        public string message;    // Message to show in console
    }

    public List<StateMessagePair> stateMessages = new List<StateMessagePair>();

    private string lastState = "";

    void Update()
    {
        if (bottomBarAnimator == null)
        {
            Debug.LogWarning("No Animator asignado al BottomBarView.");
            return;
        }

        // List of animations
        AnimatorStateInfo stateInfo = bottomBarAnimator.GetCurrentAnimatorStateInfo(0);

        foreach (var pair in stateMessages)
        {
            if (stateInfo.IsName(pair.stateName))
            {
                if (lastState != pair.stateName)
                {
                    Debug.Log(pair.message);
                    lastState = pair.stateName;
                }
                return;
            }
        }

        // If the state is not in the list, we reset
        lastState = "";
    }
}