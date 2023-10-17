using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButtonHandler : MonoBehaviour
{
    public Animator doorAnimator;

    // Attach this method to the button's OnPress event in the Unity Editor.
    public void OnButtonPress()
    {
        // Trigger the "OpenDoor" animation.
        doorAnimator.SetTrigger("OpenDoor");
    }
}