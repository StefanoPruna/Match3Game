using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space Key");
        }

        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Holding E");
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("d");
        }
    }
}
