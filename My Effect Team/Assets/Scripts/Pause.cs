using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    bool pause = false;
        // Start is called before the first frame update
    void Start()
    {
        //bool pause = false;
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Time.timeScale = 0;
        //    pause = true;
        //}

        //if (Input.GetKeyDown(KeyCode.R))
        //{
        //    Time.timeScale = 1;
        //}

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (pause == false)
            {
                Time.timeScale = 0;
                pause = true;
            }
            else
            {
                Time.timeScale = 1;
                pause = false;
            }
        }
        
    }

    
}
