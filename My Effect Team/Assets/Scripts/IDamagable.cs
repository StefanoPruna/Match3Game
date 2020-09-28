using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable //INTERFACE ARE SIMILAR TO ABSTRACT CLASSES
{
    //INTERFACE CAN ONLY USE PROPERTIES AND FUNCTIONS/METHODS
    int health { get; set; }

    void Damage(int damageAmount);

    //RELATED TO PLAYER AND ENEMY INTERFACES AND MANYFORMSINTERFACES
}
