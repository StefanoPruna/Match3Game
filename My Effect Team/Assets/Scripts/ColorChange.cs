using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{

   private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ColorChangeHelper.ChangeColor(gameObject, Color.red);
        }
        
    }
}
