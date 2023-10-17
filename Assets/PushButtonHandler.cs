using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButtonHandler : MonoBehaviour
{
    public Animator doorAnimator;
//Very simple interaction for setting the Door to open. If i tried to use the button as a trigger(and use a bool) the button would no longer press
    public void OnButtonPress()
    {
        doorAnimator.SetTrigger("OpenDoor");
    }
}