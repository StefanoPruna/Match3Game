using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    public int myBill;
    public float myTip;
    float totalAmount;
    // Or use decimal for all the vars:
    //public decimal myTip;
    //decimal totalAmount;
    //decimal percentageTip;
    // Start is called before the first frame update
    void Start()
    {
        float percentageTip = (myBill * myTip) / 100;
        totalAmount = myBill + percentageTip;
        Debug.Log("Your bill is: " + myBill + " and your tip is:  " + myTip + "%" + " thus, you owe: " + totalAmount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
