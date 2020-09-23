using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectsChallange : MonoBehaviour
{
    public GameObject[] createObjects = new GameObject[3];//Array
    public List<GameObject> objectCreated = new List<GameObject>();//List
    public int SpawnCount { get; set; }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
                                                                            
    // Update is called once per frame
    void Update()
    {
        if (SpawnCount > 10)
            return;

        if (Input.GetKeyDown(KeyCode.C))
        {
            CreateObjects();
            EndOfProject();
        }               
    }

    void CreateObjects()
    {
        var objectToSpawn = createObjects[Random.Range(0, createObjects.Length)];
        objectToSpawn = Instantiate(objectToSpawn, new Vector3(Random.Range(-10, createObjects.Length), Random.Range(-10, createObjects.Length), Random.Range(-10, createObjects.Length)), Quaternion.identity) as GameObject;

        objectCreated.Add(objectToSpawn);

        SpawnCount++;
    }

    void EndOfProject()
    {
        if (SpawnCount > 10)
        {
            foreach (var obj in objectCreated)
            {
                obj.GetComponent<MeshRenderer>().material.color = Color.green;
            }

            objectCreated.Clear();
        }
    }
}
