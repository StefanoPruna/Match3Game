using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilityHelper
{
    public static void CreateObject()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cylinder);
    }

    public static void SetPositionToZero(GameObject obj)
    {
        obj.transform.position = Vector3.zero;
    }
}
