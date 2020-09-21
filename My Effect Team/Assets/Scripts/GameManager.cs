using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /*private bool isGameOver;
    public bool IsGameOver
    {
        get
        {
            return isGameOver;
        }
        set
        {
            if (value == true)
            {
                Debug.Log("You lose! Game Over!");
            }
            isGameOver = value;
        }
    }*/

        //Cleaner way to do the Auto Properties/above:
        public bool IsGameOver { get; private set; }
        
        public bool IsSpeedOn { get; private set; }        
    public string myName { get; set; }
    public string _myName;

    float Speed { get; set; }
    private float _speed;

    



    // Start is called before the first frame update
    void Start()
    {
        //isGameOver = false;

        IsGameOver = false;
        if (IsGameOver == true)
        {

        }

        IsSpeedOn = false;
        _myName = "Loske";

        _speed = 10f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IsGameOver = true;
            Debug.Log("You lose! Game Over!");
            IsSpeedOn = true;
            Debug.Log(myName + ", You are Speeding!" + Speed);

        }
    }
}
