using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    void Start()
    {
        ButtonEvent.onClick += FallEvent;
    }

    public void FallEvent()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }

    private void OnDisable()
    {
        ButtonEvent.onClick -= FallEvent;
    }
}
