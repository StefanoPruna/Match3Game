using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnArray : MonoBehaviour
{
    public GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        enemies = GetAllEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    GameObject[] GetAllEnemies()
    {
        GameObject[] allEnemeies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach(var e in allEnemeies)
        {
            e.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }

        return allEnemeies;
    }
}
