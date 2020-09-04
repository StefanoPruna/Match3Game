using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;
    public string itemDescription;
    public int itemAttack;
    public Sprite itemIcon;

    public Item()
    {
    }

    //public SpriteRenderer myRenderer { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
      //  myRenderer = GetComponent<SpriteRenderer>();

    }   
}
