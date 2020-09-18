using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    /*public Spell fireBall;

    public int level = 1;
    public int exp;
    // Start is called before the first frame update
    void Start()
    {
        fireBall = new Spell("Fire Ball", 1, 27, 35);//35 stands for experience 

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //GetComponent<Spell>().Cast();
            fireBall.Cast();
            exp += fireBall.expGained;
        }
    }*/

    //alternative method:
    public Spell[] spells;

    public int level = 1;
    public int exp;

    public void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            foreach (var spell in spells)
            {
                if (spell.levelRequired == level)
                {
                    spell.Cast();
                    exp += spell.expGained;           
                    
                }
            }
        }
    }
}
