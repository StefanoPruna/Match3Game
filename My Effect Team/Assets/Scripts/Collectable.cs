using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    WeaponStats _blasters;

    private void Start()
    {
        _blasters = new WeaponStats("Blaster", 0.25f, 50);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            Destroy(this.gameObject);
        }
    }
}
