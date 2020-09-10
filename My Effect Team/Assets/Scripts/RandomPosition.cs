using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    public Vector3[] spawnPosition;

    //I can use both method: with the private var _randomIndex, or with the transform.position
    //int _randomIndex;

    void Start()
    {
        //_randomIndex = ChangePosition();
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ChangePosition();
        }
    }

    public void ChangePosition()
    {
        //return Random.Range(0, spawnPosition.Length);

        transform.position = new Vector3(Random.Range(0, spawnPosition.Length), Random.Range(0, spawnPosition.Length), Random.Range(0, spawnPosition.Length));
    }
}
