using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counting : MonoBehaviour
{
    private void OnEnable()
    {
        AddingCount.onCounting += ResetPlayer;
    }

    public void ResetPlayer()
    {
        Debug.Log("Counting Player");
    }
}
