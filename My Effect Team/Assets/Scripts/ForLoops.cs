using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{
    public string playerName = "Loske";
    private int countName;
    // Start is called before the first frame update
    void Start()
    {
        countName = 0;
        for (int i = 0; i < 10; i ++, countName ++)
        {
            /*print only one particular number
            if (i == 8)
            {
                Debug.Log(playerName + " " + countName);
            }*/

            /*print only even numbers with the remainder
            if (i % 2 == 0)
            {
                Debug.Log(playerName + " " + countName);
            }*/

            // to finish the loop to at certain point and won't let the loop finish
            Debug.Log(playerName + " " + countName);
            if (i == 6)
            {
                break;
            }
        }
        

        /*countName = 10;
        for (int i = 10; i > 0; i--, countName --)
        {   
              print only odd numbers with the remainder  
            if (i % 2 == 1)
            {
                Debug.Log(playerName + " " + countName);
            }
        }   */          
        
        Debug.Log("Loop has finished");


        //While loop method with function
        //StartCoroutine(LoopRoutine());
    }

    /* Update is called once per frame
    void Update()
    {

    }

    IEnumerator LoopRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            Debug.Log("Spawning Enemy Every Second");
        }
    }*/
}
