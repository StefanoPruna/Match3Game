using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LinqExample : MonoBehaviour
{
    public string[] names = { "Loske", "VictoriaBlu", "Obi Wan", "Kitty", "Yoda", "Ahsoka", "Ahsoka", "Kitty" };

    // Start is called before the first frame update
    void Start()
    {
        /*Instead of using foreach loop, we can use Linq
         * foreach (var foundName in names)
        {
            if (names == "Loske")
            {
                Debug.Log("Found " + foundName);
            }
        }*/
        //var foundName = name.Any(names => name == "Loske");
        //Or Alternative, I can use the code below:
        var foundName = names.Contains("Loske");
        Debug.Log("Found " + foundName);

        //Distinct is used to check duplicate
        var uniqueNames = names.Distinct();
        foreach(var name in uniqueNames)
        {
            Debug.Log("Name: " + name);
        }

        //Where is used with conditions, in this case print the names with more than 6 characters only
        var newList = names.Where(n => n.Length > 6);
        foreach(var newname in newList)
        {
            Debug.Log("The new list is: " + newname);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
