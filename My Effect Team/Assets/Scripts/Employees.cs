using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Employees : AbstractChallenge
{
    public string companyName;
    public string employeeName;
    public int salary;

    public Employees(string cName, string eName, int salaty)
    {
        this.companyName = cName;
        this.employeeName = eName;
        this.salary = salaty;
    }
}
