using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAllTriggersOnExit : StateMachineBehaviour
{
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Gets all the Animator parameters
        AnimatorControllerParameter[] parameters = animator.parameters;

        // Reset only those that are Triggers
        foreach (AnimatorControllerParameter param in parameters)
        {
            if (param.type == AnimatorControllerParameterType.Trigger)
            {
                animator.ResetTrigger(param.name);
            }
        }
    }
}
