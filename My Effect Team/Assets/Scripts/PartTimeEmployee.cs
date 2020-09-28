using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartTimeEmployee : AbstractChallenge
{
    public int hoursWorked;
    public int hourlyRate;
    private int _partTimeSalary;

    public override void CalculateMonthlySalary()
    {
        throw new System.NotImplementedException();
    }

    public override void PartTSalary()
    {
        _partTimeSalary = hoursWorked * hourlyRate;
        Debug.Log(_partTimeSalary);
    }
}
