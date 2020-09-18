using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ColorChangeHelper //REMOVE MONOBEHAVIOR BECAUSE IT'S STATIC 
{    
    public static void ChangeColor(GameObject obj, Color color)
    {
        color = new Color(Random.value, Random.value, Random.value);
        obj.GetComponent<Renderer>().material.color = color; //Random.ColorHSV();
    }

    
}
