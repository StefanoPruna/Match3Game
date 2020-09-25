using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBwithDictionary : MonoBehaviour
{
    //DICTIONARY IS SIMILAR TO A LIST, BUT WITH A LIST I HAVE TO USE THE FOR LOOP TO CHECK EVERY SINGLE DATA IN THE LIST
    //WITH THE DICTIONARY I ASSOCIATE AN ID TO EACH DATA AND THEN RECALL THAT DATA WITH THE ID, THUS IT'S GOOD TO USE IT WHEN YOU HAVE A LOT OF ITEMS/DATA

    public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();

    // Start is called before the first frame update
    void Start()
    {
        Item sword = new Item();//value
        sword.name = "Big Sword";
        sword.id = 0;

        Item bread = new Item();
        bread.name = "Small health receive";
        bread.id = 1;

        Item potion = new Item();
        potion.name = "Medium health recovery";
        potion.id = 2;

        Item secretKey = new Item();
        secretKey.name = "Secret key to open a chest";
        secretKey.id = 60;//Key

        itemDictionary.Add(0, sword);
        itemDictionary.Add(1, bread);
        itemDictionary.Add(2, potion);
        itemDictionary.Add(60, secretKey);

        //var item = itemDictionary[0];//STORE THE DATA WITH ID=0 TO THE VAR ITEM, IN THIS CASE THE SWORD;BELOW ANOTHER WAY TO STORE DATA IN ITEM VAR
        
        /*foreach(KeyValuePair<int, Item> item in itemDictionary)
        {
            Debug.Log("Key: " + item.Key);
            Debug.Log("Value: " + item.Value.name);
        }*/

        /*foreach(Item item in itemDictionary.Values)
        {
            Debug.Log("Item name: " + item.name);
        }*/

        if(itemDictionary.ContainsKey(61))
        {
            Debug.Log("You found the secret key to open the chest!");
            var item = itemDictionary[61];
        }
        else if(itemDictionary.ContainsValue(sword))
        {
            Debug.Log("You have found a sword");
            var item = itemDictionary[sword.id];
        }
        else
        {
            Debug.Log("You don't have the secret key to open the chest");
        }
    }
}
