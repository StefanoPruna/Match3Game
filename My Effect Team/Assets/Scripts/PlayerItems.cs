using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItems : MonoBehaviour
{
    public Item[] inventory = new Item[10];

    private ItemDB _itemDatabase;

    // Start is called before the first frame update
    void Start()
    {
        _itemDatabase = GameObject.Find("Items").GetComponent<ItemDB>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            //request item by ID
            _itemDatabase.AddItem(0, this);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            //remove item by ID
            _itemDatabase.RemoveItem(0, this);
        }
    }
}
