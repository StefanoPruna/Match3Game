using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //PROPERTIES
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

    //    //Cleaner way to do the Auto Properties/above:
    //    public bool IsGameOver { get; private set; }

    //    public bool IsSpeedOn { get; private set; }        
    //public string myName { get; set; }
    //public string _myName;

    //float Speed { get; set; }
    //private float _speed;





    //// Start is called before the first frame update
    //void Start()
    //{
    //    //isGameOver = false;

    //    IsGameOver = false;
    //    if (IsGameOver == true)
    //    {

    //    }

    //    IsSpeedOn = false;
    //    _myName = "Loske";

    //    _speed = 10f;

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        IsGameOver = true;
    //        Debug.Log("You lose! Game Over!");
    //        IsSpeedOn = true;
    //        Debug.Log(myName + ", You are Speeding!" + Speed);

    //    }
    //}END OF PROPERTIES


    /*Creating Lists:
    public List<GameObject> enemiesToSpawn = new List<GameObject>();//LISTS ARE DYNAMIC
    public GameObject[] objectsToSpawn = new GameObject[10];//ARRAYS ARE STATIC, YOU HAVE TO PROVIDE THE NUMBER

    private void Start()
    {
        objectsToSpawn[0] = new GameObject();
        enemiesToSpawn.Add(new GameObject());
        //ACCESS OR INTERACT WITH DATA IN THE SAME WAY
        objectsToSpawn[2].name = "John";
        enemiesToSpawn[4].name = "Loske";
    }*/

    public List<string> someNames = new List<string>();
        
    private void Start()
    {        
        //foreach(var names in someNames)
        //{
        //    Debug.Log(names);
        //}               
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var nameToRemove = someNames[Random.Range(0, someNames.Count)];
            someNames.Remove(nameToRemove);

            //someNames.Remove(someNames[Random.Range(0, someNames.Count)]);

            foreach (var newName in someNames)
                {            
                    Debug.Log(newName);
                }

            Debug.Log("We remove the following name:" + nameToRemove);            
        }
    }
}
