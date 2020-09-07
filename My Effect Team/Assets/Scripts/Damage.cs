using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int health;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            damage = Random.Range(1, 25);
            damageReceive();
        }
        
    }

    public void damageReceive()
    {
        health -= damage;
        if(health <= 0)
        {
            Debug.Log("Cube is destroyed!");
            //Destroy(this.gameObject);
            health = 0;            
        }        
    }
}
