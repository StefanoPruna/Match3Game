using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Called this class from Customers script
/*[System.Serializable]
public class Customer
    {
        public string name;
        public string familyName;
        public int age;
        public string gender;
        public string occupation;
        public Customer (string name, string familyName, int age, string gender, string occupation)
        {
            this.name = name;
            this.familyName = familyName;
            this.age = age;
            this.gender = gender;
            this.occupation = occupation;
        } 
    }*/
public class CustomerDatabase : MonoBehaviour
{
    //public Customer[] Customers;

    //calling the other Class and defying 
    public Customers[] Customer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            int randomCustomer = Random.Range(0, Customer.Length);
            Debug.Log("Name and Family Name: " + Customer[randomCustomer].name + " " + Customer[randomCustomer].familyName + ", Eta': " + Customer[randomCustomer].age + ", " + "Type:  " + Customer[randomCustomer].gender + ", " + "Occupation: " + Customer[randomCustomer].occupation);
        }
        
    }
}
