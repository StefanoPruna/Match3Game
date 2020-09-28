using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInterface : MonoBehaviour, IDamagable, Shoot
{
    public int health { get; set; }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public void DamageShoot()
    {
        throw new System.NotImplementedException();
    }

    //I CAN DECLARE THE ABOVE DATA TYPES AND THE FUNCTIONS/METHODS MANUALLY, CHECK PLAYERINTERFACE SCRIPT; 
    //ALTERNATIVELY, I CAN RIGHT-CLICK ON THE "IDamagable" or "Shoot" INTERFACES,
    //SELECT QUICK ACTIONS AND REFACTORINGS... AND AUTOMATICALLY IT WILL CREATE THEM FOR YOU
    //IDamagable and Shoot are Interfaces and not classes
}
