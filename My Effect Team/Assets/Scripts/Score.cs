using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    //private AddScore _score;

    // Start is called before the first frame update
    void Start()
    {
        //_score = GameObject.Find("Add score").GetComponent<AddScore>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            //add 10 points to score
            //_score.score += 10;

            AddScore.score += 10;
            Debug.Log("Current Score: " + AddScore.score);
        }
        
    }
}
