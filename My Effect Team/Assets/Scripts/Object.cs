using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            UtilityHelper.CreateObject();
        }
    }
}
