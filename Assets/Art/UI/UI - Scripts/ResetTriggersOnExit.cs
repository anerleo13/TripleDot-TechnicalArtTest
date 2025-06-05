using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTriggersOnExit : StateMachineBehaviour
{
    public string[] triggersToReset; // Array of trigger names to reset

    // Executed when exiting the animation state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Resets all specified triggers
        foreach (string triggerName in triggersToReset)
        {
            animator.ResetTrigger(triggerName);
        }
    }
}