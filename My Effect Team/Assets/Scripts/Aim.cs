using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    //[SerializeField]
    //public int weaponID;
    

    [SerializeField]
    // Always use _ in front of PRIVATE variable!!!
    private Transform _Powerup;
    private bool destroyed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionToFace = _Powerup.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(directionToFace);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);
        if(destroyed == true)
        {

        }

        //if (Input.GetKeyDown(KeyCode.G))
        //{
        //    weaponID = 1;
        //}
        //if (Input.GetKeyDown(KeyCode.K))
        //{
        //    weaponID = 2;
        //}
        //if (Input.GetKeyDown(KeyCode.M))
        //{
        //    weaponID = 3;
        //}
        //switch (weaponID)
        //{
        //    case 1:
        //        Debug.Log("You have choose a Gun");
        //        break;
        //    case 2:
        //        Debug.Log("You have choose a Knife");
        //        break;
        //    case 3:
        //        Debug.Log("You have choose a Machine Gun");
        //        break;
        //    default:
        //        Debug.Log("You have no weapon");
        //        break;
        //}
     }       
}
