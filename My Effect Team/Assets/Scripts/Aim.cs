using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField]
    // Always use _ in front of PRIVATE variable!!!
    private Transform _Powerup;
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
    }
}
