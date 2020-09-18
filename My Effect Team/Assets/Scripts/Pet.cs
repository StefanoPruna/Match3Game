using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pet : MonoBehaviour
{
    public string petName;

    protected virtual void Speak()
    {
        Debug.Log("The pet's sound is: " + petName);
    }

    private void Start()
    {
        Speak();
    }
}
