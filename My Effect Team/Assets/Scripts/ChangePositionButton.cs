using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePositionButton : MonoBehaviour
{
    public delegate void ActionClick();
    public static event ActionClick onClick;

    public void ChangePosition()
    {
        onClick?.Invoke();
    }
}
