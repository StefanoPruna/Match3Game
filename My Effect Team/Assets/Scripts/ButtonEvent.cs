using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour 
    //MAIN EVENT FOR THE BUTTON ASSOCIATED TO MAIN CAMERA: REFER TO LISTENERS AND FALL EVENTS
{
    public delegate void ActionClick();
    public static event ActionClick onClick;

    public void ButtonClick()
    {
        if (onClick != null)
            onClick();
    }
}
