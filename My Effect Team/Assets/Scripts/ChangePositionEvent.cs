using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePositionEvent : MonoBehaviour
{
    public Vector3[] spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        ChangePositionButton.onClick += ChangePosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangePosition()
    {
        //transform.position = new Vector3(5, 2, 0);
        transform.position = new Vector3(Random.Range(-2, spawnPosition.Length), Random.Range(-2, spawnPosition.Length), 0);
    }

    private void OnDisable()
    {
        ChangePositionButton.onClick -= ChangePosition;
    }
}
