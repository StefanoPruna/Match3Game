using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFromDifferentArray : MonoBehaviour
{
    public string[] names;
    public int[] ages;
    public string[] carModels;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            int randomCar = Random.Range(0, names.Length);
            Debug.Log(names[randomCar] + " " + ages[randomCar] + " " + carModels[randomCar]);
        }
        
    }
}
