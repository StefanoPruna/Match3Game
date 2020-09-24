using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<Item> ItemDatabase = new List<Item>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            ItemDatabase[Random.Range(0, ItemDatabase.Count)].Action();
        }
        
    }

    public void AddItem(int itemID, PlayerItems playerItem)
    {
        //check if item matches something in the database
        foreach(var item in ItemDatabase)
        {
            if (item.id == itemID)
            {
                Debug.Log("We have this item in the database");
                playerItem.inventory[0] = item;
                return;
            }
        }

        Debug.Log("We don't have this item in the database");
    }

    public void RemoveItem(int itemID, PlayerItems playerItem)
    {
        foreach(var item in ItemDatabase)
        {
            if (item.id == itemID)
            {
                playerItem.inventory[0] = null; //IN AN ARRAY YOU HAVE TO NULL, IN A LIST YOU USE CLEAR()
            }
        }
    }
}
