using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    //int i = 6;

    private int speed;
    //private int maxSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //do
        //{
        //    Debug.Log(i);

        //    /*With do while loop you have to increament the var or use a statement, otherwise 
        //     you will have the infinite loop and crash the program*/

        //    if (i <= 6)
        //    {
        //        i++;//the do loop will run at least once regardless
        //    }
        //} while (i < 6);

        speed = 0;
        //maxSpeed = Random.Range(60, 120);
        StartCoroutine(AddLoskeRoutine());


        //for the While loop method with function check "ForLoops" script
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AddLoskeRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            Debug.Log(speed + "Km all'ora");
            speed += 5; //if i don't increase the var, it will go to the infinite loop and crash it

            if (speed > 59)
            {
                speed = Random.Range(60, 120);
                if (speed > 110)
                {
                    Debug.Log("Ti sei fermato");
                    break;
                }
            }

            /*if (speed > maxSpeed)
            {
                Debug.Log("Ti sei fermato");
                break;
            }*/
        }
    }
}
