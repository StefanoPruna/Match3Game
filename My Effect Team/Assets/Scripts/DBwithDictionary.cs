using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBwithDictionary : MonoBehaviour
{
    public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();

    // Start is called before the first frame update
    void Start()
    {
        Item sword = new Item();
        sword.name = "Big Sword";
        sword.id = 0;
        

        itemDictionary.Add(0, sword);

        var item = itemDictionary[0];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
