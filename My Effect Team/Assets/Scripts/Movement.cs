using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //THREE METHODS FOR MOVEMENT
    
    void Start()
    {
        //1st method
        //transform.position = new Vector3(0, 0, 0);

        //2nd method by calling a function
        //ChangePosition();
        //Alternative for the 2nd method
        //ChangePosition(new Vector3(0, 0, 0));

        //3rd method with return in function
        //transform.position = GetPosition();
        //Alternate 3rd method
        //transform.position = GetPosition(0, 0, 0);
    }

    
    void Update()
    {
        
    }

    //2nd method
    //public void ChangePosition()
    //{
    //    transform.position = Vector3.zero;
    //}
    //2nd method alternative
    //public void ChangePosition(Vector3 pos)
    //{
    //    transform.position = pos;
    //}

    //3rd method
    //public void ChangePosition(Vector3 pos)
    //{
    //    transform.position = pos;
    //}

    //public Vector3 GetPosition()
    //{
    //    return Vector3.zero;
    //}
    //alternate 3rd method
    //public Vector3 GetPosition(float x, float y, float z)
    //{
    //    Vector3 pos = new Vector3(x, y, z);
    //    return pos;
    //}
}
