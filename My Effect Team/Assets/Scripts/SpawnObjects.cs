using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public List<GameObject> generateObj = new List<GameObject>();
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            GenerateObjects();
            ChangePosition();
        }
        
    }

    public void ChangePosition()
    {
        transform.position = new Vector3(Random.Range(0, generateObj.Count), Random.Range(0, generateObj.Count), Random.Range(0, generateObj.Count));
    }

    public void GenerateObjects()
    {
        GameObject[] createEnemies = GameObject.FindGameObjectsWithTag("Enemy");       
        generateObj.Add(new GameObject(tag = "Enemy"));

        if (generateObj.Count > 10)
        {
            foreach (var c in createEnemies)
            {
                c.GetComponent<MeshRenderer>().material.color = Color.green;
                generateObj.Clear();
            }
        }
    }
}
