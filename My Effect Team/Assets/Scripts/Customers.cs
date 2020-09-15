using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Customers //if I keep the MonoBehaviour, the Inspector will wait for Objects to be add/assigned to
{
    public string name;
    public string familyName;
    public int age;
    public string gender;
    public string occupation;
    public Customers(string name, string familyName, int age, string gender, string occupation)
    {
        this.name = name;
        this.familyName = familyName;
        this.age = age;
        this.gender = gender;
        this.occupation = occupation;
    }

    //public Customers[] Customer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
