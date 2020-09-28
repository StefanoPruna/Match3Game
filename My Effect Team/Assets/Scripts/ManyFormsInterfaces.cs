using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManyFormsInterfaces : MonoBehaviour //POLYMOROHISM, OR MANY FORMS OF INTERFACES SCRIPT ATTACHED TO MAIN CAMERA
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                /*if (hitInfo.collider.name == "Player Interface") //CHECK IN THE PREFABS FOR PLAYER AND ENEMY INTERFACE
                    hitInfo.collider.GetComponent<PlayerInterface>().Damage(100);
                else if (hitInfo.collider.name == "Enemy Interface")
                    hitInfo.collider.GetComponent<EnemyInterface>().Damage(100); 
                  IF I HAVE A LOT OF PLAYERS AND/OR ENEMIES, I CAN CHECK FOR THE INTERFACES*/
                IDamagable obj = hitInfo.collider.GetComponent<IDamagable>();

                if (obj !=null)
                {
                    obj.Damage(100);
                }

            }
        }
    }
}
