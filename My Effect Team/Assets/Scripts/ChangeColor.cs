using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject cylinder;
    private int _changeColor;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        cylinder.GetComponentInChildren<Renderer>().material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            _changeColor = 0;
            //gameObject.GetComponent<Renderer>().material.color = Color.blue;
            //cylinder.GetComponent<Renderer>().material.color = Color.magenta;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            _changeColor = 1;
            //gameObject.GetComponent<Renderer>().material.color = Color.red;
            //cylinder.GetComponentInChildren<Renderer>().material.color = Color.yellow;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            _changeColor = 2;
            //gameObject.GetComponent<Renderer>().material.color = Color.green;
            //cylinder.GetComponentInChildren<Renderer>().material.color = Color.gray;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            _changeColor = 3;
            //gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            //cylinder.GetComponentInChildren<Renderer>().material.color = Color.green;
        }
        
        switch (_changeColor)
        {
            case 0:
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                cylinder.GetComponent<Renderer>().material.color = Color.magenta;
                break;
            case 1:
                gameObject.GetComponent<Renderer>().material.color = Color.red;
                cylinder.GetComponentInChildren<Renderer>().material.color = Color.yellow;
                break;
            case 2:
                gameObject.GetComponent<Renderer>().material.color = Color.green;
                cylinder.GetComponentInChildren<Renderer>().material.color = Color.gray;
                break;
            case 3:
                gameObject.GetComponent<Renderer>().material.color = Color.cyan;
                cylinder.GetComponentInChildren<Renderer>().material.color = Color.green;
                break;
        }


    }
}
