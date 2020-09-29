using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//public class Items
//{
//    public string name;
//    public int itemID;
//    public int buff;
//}

public class LinqChallengeTwo : MonoBehaviour
{
    public List<Item> itemList;//It inherits list from the class/script Item

    private bool _checkID = false;

    // Start is called before the first frame update
    void Start()
    {
        /*var result = itemList.Any(i => i.id == 3);
        Debug.Log("Result: " + result);*/
        var checkID = itemList.Where(i => i.id == 3);
        foreach(var printID in checkID)
        {      
             Debug.Log("Whic item is the ID 3? Yes, it is the: " + printID.name);
        }

        var checkBuff = itemList.Where(buff => buff.buff > 20);
        foreach(var printbuff in checkBuff)
        {
            Debug.Log("Item with buff greater than 20 is: " + printbuff.name);
        }

        var buffAve = itemList.Average(ave => ave.buff);        
            Debug.Log("The average of the buff in the Item list is: " + buffAve);
    }
}
