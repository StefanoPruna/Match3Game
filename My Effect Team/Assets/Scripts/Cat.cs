using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cat : Pet
{
    
    protected override void Speak()
    {
        //base.Speak();
        //To override a function from another script, I have to add virtual in the original function script, check Pet script for more info
        Debug.Log("Meaow");
    }
}
