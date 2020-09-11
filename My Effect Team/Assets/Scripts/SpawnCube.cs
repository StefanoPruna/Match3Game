using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    [SerializeField]
    private GameObject cubePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            // with identity, there is not rotation 
            //Instantiate(cubePrefab, Vector3.zero, Quaternion.identity);
            Instantiate(cubePrefab, Vector3.zero, Quaternion.Euler(0,35, 0));
        }
    }
}
