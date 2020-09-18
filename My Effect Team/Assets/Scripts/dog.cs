using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dog : Pet
{
    protected override void Speak()
    {
        //base.Speak();
        Debug.Log("Wof Wof");
    }
}
