﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public struct Item2 VALUE TYPE ARE bool, bytes, char, float, int, structs and ARE STORED AS STACK
                   THE DIFFERENCE BETWEEN VALUE TYPES AND REFERENCE TYPES IS HOW THEY USED THE MEMORY TO STORE DATA
                   AND YOU CANNOT OVERRIDE THE VALUE TYPES WHILE YOU CAN DO IT FOR THE REFERENCE TYPES
{
    public string itemName;
    public int itemId;


    public Item2(string itemName, int itemID)
    {
        this.itemName = itemName;
        this.itemId = itemID;
    }
}*/

[System.Serializable]
public class Item //REFERENCE TYPE ARE STORED AS HEAP
{    
    public string name;
    public int id;
    public string description;
    public Sprite Icon;
    
    public Item(string name, int id, string description)
    {
        this.name = name;
        this.id = id;
        this.description = description;
    }
}
