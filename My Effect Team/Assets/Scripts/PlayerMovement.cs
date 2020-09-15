using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStats
{
    /*public string name;
    public float fireRate;
    public int ammoCount;

    //Constructor = initialize here
    public WeaponStats(string name, float fireRate, int ammoCount)
    {
        this.name = name;
        this.fireRate = fireRate;
        this.ammoCount = ammoCount;
    }*/
}

public class PlayerMovement : MonoBehaviour
{
    public Vector3[] randomPosition;

    [SerializeField]
    private float _speed;

    //private WeaponStats _blasters;
    //private WeaponStats _rockets;

    // Start is called before the first frame update
    void Start()
    {
        /* It's better use the constructor in the WeaponStats(custom) class to initialize the var/object
        _blasters = new WeaponStats();
        _blasters.name = "Blasters";
        _blasters.fireRate = 0.25f;
        _blasters.ammoCount = 50;
        _rockets = new WeaponStats();
        _rockets.name = "Rockets";
        _rockets.fireRate = 0.45f;
        _rockets.ammoCount = 20;
            
        _blasters = new WeaponStats("Blasters", 0.25f, 50);
        _rockets = new WeaponStats("Rockets", 0.45f, 20);
        */
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if(Input.GetKeyDown(KeyCode.M))
        {
            GetComponent<RandomPosition>().ChangePosition();
        }
    }

    public void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput, 0, 0) * _speed * Time.deltaTime);
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, verticalInput, 0) * _speed * Time.deltaTime);
    }
}
