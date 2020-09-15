using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//[System.Serializable]
// public class Items
// {
//     // public int itemId;
//     // public string itemName;
//     // public string description;
// }

public class Array : MonoBehaviour
{
    //Examples of Array:
    //public string[] items = new string[5];

    //public int[] ages = new int[] { 5, 3, 2, 50 };

    //with Unity, we can specify the size through the inspector and also be able to modify it, 
    //but we have to save everytime
    public string[] names;
    public int[] ages;
    public string[] carModels;
    private int randomNames;
    

    /*public int[] itemId;
    public string[] itemName;

    private int randomItem;
    */

    //public Items[] myItems;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(names[Random.Range(0, names.Length)]);                  

        /*foreach(var item in myItems)
        {
            Debug.Log(item.itemId + "." + item.itemName + "= " + item.description);
        }*/
            //Or I can use the For loop
        // for(int i = 0; i < myItems.Length; i++)
        // {
        //     Debug.Log(myItems[i].itemId + "." + myItems[i].itemName + "= " + myItems[i].description);
        //     if(myItems.Length == 7)
        //     {
        //         Debug.Log("You have it!");
        //     }
        //     else
        //     {
        //         Debug.Log("You don't have it!");
        //     }
        // }
    }

    // Update is called once per frame
    void Update()
    {

        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(names[4] + ages[4] + carModels[4]);
            Debug.Log(ages[4]);
            Debug.Log(carModels[4]);
        }*/

        randomNames = Random.Range(0, names.Length);
        Debug.Log(names[randomNames] + " " + ages[randomNames] + " " + carModels[randomNames]);

        //if (Input.GetKeyDown(KeyCode.Space))
        {
            /*for(int i = 0; i < itemId.Length && i < itemName.Length; i++)
            {
                //    Debug.Log(itemId[i] + " " + itemName[i]);

                //if(itemId[i] == 4)
                //{
                //    Debug.Log("Item Name: " + itemId[4] + " " + itemName[4]);
                //}

                //randomItem = Random.Range(0, itemId.Length);
                //Debug.Log(itemId[randomItem] + " " + itemName[randomItem]);
            }*/

            //foreach (var item in itemName)
            //{
            //    Debug.Log(item);
            //}

            /*if(Input.GetKeyDown(KeyCode.Space))
            {
                int randomId = Random.Range(0, myItems.Length);
                Debug.Log(myItems[randomId].itemId + "." + myItems[randomId].itemName + "= " + myItems[randomId].description);
            }*/
        }
    }

}
