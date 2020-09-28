using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingCount : MonoBehaviour
{
    public delegate void OnCounting();
    public static event OnCounting onCounting;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            AddCount();
        }
    }

    void AddCount()
    {
        if (onCounting != null)
        {
            onCounting();
        }
    }
}
