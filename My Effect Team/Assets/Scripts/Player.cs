using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int points;

    //public float testOne, testTwo, testThree, testFour, testFive;
    //float testAverage;


    //private int _difficultyEasy = 0; int _difficultyMedium = 1; int _difficultyHard = 2;
    //public int difficultyCurrent;


    //We keep the var private for the Player only, but we show it in Unity/inspector
    //[SerializeField]
    //private int _myPoint = 0;
    //[SerializeField]
    //private bool _hasAlreadyPrinted;

    //public Vector3 startPosition;
    //public string myName = "Loske";
    //public int myAge = 41;
    //public float mySpeed = 5f;
    //public int myHealth;
    //public int myScore;
    //public int speed;
    //public bool hasAllKeys;
    //public int ammoCount;

    public GameObject[] cubes;

    void Start()
    {
        //testAverage = (testOne + testTwo + testThree + testFour + testFive) / 5;
        //testAverage = Mathf.Round(testAverage * 10f) / 10f;

        //difficultyCurrent = _difficultyMedium;
        
        //myHealth = 100;
        //myScore = 0;
        //hasAllKeys = false;
        //ammoCount = 100;
        //Debug.Log("My name is: " + myName + " and my age is " + myAge);
        //Debug.Log("My speed is: " + mySpeed);
        //Debug.Log("My Health: " + myHealth);
        //Debug.Log("My Score: " + myScore);
        //Debug.Log("My Ammo: " + ammoCount);
        //Debug.Log(hasAllKeys);
        //transform.position = startPosition;
    }

    
    void Update()
    {
        //if (testAverage > 90)
        //{
        //    Debug.Log("A " + testAverage);
        //}

        //else if (testAverage >= 80 && testAverage < 90)
        //{
        //    Debug.Log("B " + testAverage);
        //}

        //else if (testAverage >= 70 && testAverage < 80)
        //{
        //    Debug.Log("C " + testAverage);
        //}

        //else
        //{
        //    Debug.Log("F " + testAverage);
        //}

        /*if (difficultyCurrent == _difficultyEasy)
        {
            Debug.Log("You have selected easy difficulty");

        }

        else if (difficultyCurrent == _difficultyMedium)
        {
            Debug.Log("You have selected medium difficulty");

        }

        else if (difficultyCurrent == _difficultyHard)
        {
            Debug.Log("You have selected hard difficulty");

        }

        else
        {
            Debug.Log("Invalid level selected");

        }*/
        // When there are more than two else if statement, I should use Switch statement instead
        /*switch(difficultyCurrent)
        {
            case 0: //easy
                Debug.Log("You have selected easy difficulty");
                break;
            case 1: //medium
                Debug.Log("You have selected medium difficulty");
                break;
            case 2: //hard
                Debug.Log("You have selected hard difficulty");
                break;
            default:
                Debug.Log("Invalid level selected");
                break;
        }*/

        /*if (Input.GetKeyDown(KeyCode.Q))
        {
            points = 50;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            points = 100;
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            points = 0;
        }

        switch (points)
        {
            case 50:
                points = 50;
                Debug.Log("Points are 50");
                break;
            case 100:
                points = 100;
                Debug.Log("points are 100");
                break;
            case 0: //or default
                points = 0;
                Debug.Log("You need 60 or 100 points to receive a message");
                break;
        }*/

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    _myPoint += 10;
        //    Debug.Log(_myPoint);
        //    if (_myPoint >= 50 && _hasAlreadyPrinted == false)
        //    {
        //        Debug.Log("YOU ARE AWESOME!");
        //        _hasAlreadyPrinted = true;
        //    }
        //}      

        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            //foreach(var cube in cubes)
            //{
            //    cube.GetComponent<MeshRenderer>().material.color = Color.red;
            //}
            //Or I can use the For loop
            for(int i = 0; i < cubes.Length; i++)
            {
                cubes[i].GetComponent<MeshRenderer>().material.color = Color.blue;
            }
        }*/

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeTheCube();
        }        
    }

    public void ChangeTheCube()
    {
        cubes[2].GetComponent<MeshRenderer>().material.color = Color.green;
        cubes[1].GetComponent<MeshRenderer>(). = ;
    }
}
