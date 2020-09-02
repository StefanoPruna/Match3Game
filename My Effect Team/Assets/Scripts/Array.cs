using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    //Examples of Array:
    //public string[] items = new string[5];

    //public int[] ages = new int[] { 5, 3, 2, 50 };

    //with Unity, we can specify the size through the inspector and also be able to modify it, 
    //but we have to save everytime
    public string[] names;
    public int[] ages;
    public string[] carModels;
    
                
    // Start is called before the first frame update
    void Start()
    {        
        Debug.Log(names[Random.Range(0, names.Length)]);
                
        //Debug.Log(items[1]);
        //Debug.Log(ages[2]);             
    }

    // Update is called once per frame
    void Update()
    {        
        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(names[4] + ages[4] + carModels[4]);
            //Debug.Log(ages[4]);
            //Debug.Log(carModels[4]);
        }*/       
    }
}
