using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public int health;

    // Start is called before the first frame update
    void Start()
    {        
        //Debug.Log("Start my function: ");
        //MyMethod();
        //Debug.Log("Completed calling MyMethod");
    }

    private void Damage(int damageAmount)
    {
        health -= damageAmount;
        if(health < 1)
        {
            health = 0;
            Debug.Log("Your health is: " + health);
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Damage(10);
        }        
    }

    //void MyMethod()
    //{
    //    Debug.Log("MyMethod()");
    //}
}
