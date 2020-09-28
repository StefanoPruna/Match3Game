using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerText : MonoBehaviour
{
    public int count;
    public UIManagerText CountText;

    public void OnEnable()
    {
        AddingCount.onCounting += UpdateCount;
    }
    public void UpdateCount()
    {
        count++;
        CountText.CountText = "Counting: " + count;
    }

    public static implicit operator UIManagerText(string v)
    {
        throw new NotImplementedException();
    }
}
