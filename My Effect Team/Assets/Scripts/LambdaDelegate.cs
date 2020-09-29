using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //Needed to declare a Func and Action
public class LambdaDelegate : MonoBehaviour
{
    //public Func<string, int> CharacterLength;

    //public Action<int, int> Sum;
    //other ways to do the sum with return lambda
    public Func<int, int, int> onCalculateSum;

    // Start is called before the first frame update
    void Start()
    {
        /*CharacterLength = (name) => name.Length;
        int count = CharacterLength("Loske");
        Debug.Log("Count: " + count);
        */

        /*Sum = (a, b) =>
        {
            var total = a + b;
            if (total < 100)
            {
                Debug.Log("Total is less than 100");
            }

            Debug.Log("total: " + total);
        };

        Sum(5, 2);*/

        /*onCalculateSum = (a, b) => a + b; //=> needed for return lambda 
        var total = onCalculateSum(5, 5);// If I use this line of code, I don't need the CalculateSum function below
        */
        //Alternate way to do the sum:
        onCalculateSum = (a, b) =>
        {
            return a + b;//even in this case i don't need the CalculateSum fuction below
        };
    }
    //int CalculateSum(int a, int b)
    //{
    //    return a + b;
    //}

}
