using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listeners : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //REFERING TO BUTTONEVENT SCRIPT/EVENT
        ButtonEvent.onClick += TurnRed;
    }

    public void TurnRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    private void OnDisable()
    {
        ButtonEvent.onClick -= TurnRed;
    }
}
