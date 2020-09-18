using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public Itemslist goldCoin = new Itemslist();
    public Weapon sword = new Weapon();
    public Consumable bread = new Consumable();
       
    //public Item sword; //I can see this item in the inspector, because in the 
                        //Item script I've added [System.Serializable]

    public Item[] items;
    void Start()
    {
        //Debug.Log(items[1].name);
     
        //sword = new Item("Sword", 1, "This is a sword");
        // sword.name = "Sword";
        // sword.id = 1;
        // sword.description = "This is a sword";  

        //CreateItem("Bread", 2, "This is bread");    
    }

    // private void CreateItem(string name, int id, string description)
    // {
    //     var item = new Item(name, id, description);
    // }

    void Update()
    {
           if(Input.GetKeyDown(KeyCode.J))
        {
            RandomItem();
        }
    }

    private void RandomItem()
    {        
            int _randomItem = Random.Range(0, items.Length);
            Debug.Log(items[_randomItem].name + " " + items[_randomItem].id + " " + items[_randomItem].description);
                
    }

}
