using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bank 
{
    protected string branchName; 
    //PROTECTED can be called from others scripts if the inheritance is the same class, in this case Bank
    public string location;
    public int cashInVault;

    protected void CheckBalance()
    {
        Debug.Log("Checking the Balance: " + branchName);
    }

    public void Withdrawl()
    {
        Debug.Log("Withdrawling Money from: " + branchName);
    }

    public void Deposit()
    {
        Debug.Log("Depositing money to: " + branchName);
    }
}
