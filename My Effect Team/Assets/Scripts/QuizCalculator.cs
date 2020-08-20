using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    public float quizOne, quizTwo, quizThree, quizFour, quizFive;
    //public float quizTwo;
    //public float quizThree;
    //public float quizFour;
    //public float quizFive;

    float quizAverage;
    // Start is called before the first frame update
    void Start()
    {
        //For manually insert value to each variables
        quizAverage = (quizOne + quizTwo + quizThree + quizFour + quizFive) / 5;

        //For Randomly insert value by Unity/inspector
        //quizOne = Random.Range(0f, 100f);
        //quizTwo = Random.Range(0f, 100f);
        //quizThree = Random.Range(0f, 100f);
        //quizFour = Random.Range(0f, 100f);
        //quizFive = Random.Range(0f, 100f);

        // To have more decimal numbers, add more 0f after / = / 100f for 2 decimals; / 1000f for 3 decimals and so on
        quizAverage = Mathf.Round(quizAverage * 100f) / 10f;

        Debug.Log("The average amount is: " + quizAverage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
