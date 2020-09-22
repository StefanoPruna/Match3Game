using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class List : MonoBehaviour
{
    public List<GameObject> somePlayers = new List<GameObject>();
    public List<string> fewPlayers = new List<string>();
    
    // Start is called before the first frame update
    void Start()
    {
        //foreach (var player in somePlayers)
        //{
        //    Debug.Log(player);
        //}     
        
    }

    // Update is called once per frame
    void Update()
    {        
        if (Input.GetKeyDown(KeyCode.N))
        {
            fewPlayers.Remove(fewPlayers[Random.Range(0, fewPlayers.Count)]);

            foreach (var newPlayer in fewPlayers)
                {                
                    Debug.Log(newPlayer);
                }   
        }
        
    }

    
}
