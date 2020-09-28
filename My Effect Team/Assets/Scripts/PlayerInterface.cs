using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInterface : MonoBehaviour, IDamagable
{
    public int health { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public void Damage(int damageAmount)
    {
        //throw new System.NotImplementedException();
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    //I CAN DECLARE THE ABOVE DATA TYPE AND THE FUNCTION/METHOD MANUALLY, CHECK THE ENEMYINTERFACE SCRIPT;
    //ALTERNATIVELY, I CAN RIGHT-CLICK ON THE "IDamagable" INTERFACE,
    //SELECT QUICK ACTIONS AND REFACTORINGS... AND AUTOMATICALLY IT WILL CREATE THE SAME
    //IDamagable is Interface and not class
}
