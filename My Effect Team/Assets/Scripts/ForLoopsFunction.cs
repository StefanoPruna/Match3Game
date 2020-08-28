using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopsFunction : MonoBehaviour
{
    public string playerName;    
    private int countName;
    // Start is called before the first frame update
    void Start()
    {
        countName = 0;        
        for (int i = 0; i < 31; i++, countName++)
        {
            if (i < 10)
            {
                Debug.Log(playerName + " " + countName);
            }

            else if (i > 9 && i < 21 && i % 2 == 0)
            {
                Debug.Log(playerName + " " + countName);
            }

            else if (i > 20 && i % 2 == 1)
            {
                Debug.Log(playerName + " " + countName);
            }

        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
