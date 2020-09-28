using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractChallenge : MonoBehaviour //ABSTRACT CAN FORCE AN INHERITENCE BETWEEN CLASSES
{
    public static string company = "GameDevHQ"; 
    public string employeeName;
    
    public abstract void CalculateMonthlySalary();

    public abstract void PartTSalary();
}


