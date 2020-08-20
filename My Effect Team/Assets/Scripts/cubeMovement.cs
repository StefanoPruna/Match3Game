using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovement : MonoBehaviour
{
    public GameObject cube;
    [SerializeField]
    private int _scoreValue;
    [SerializeField]
    private int _speedValue;
    // Start is called before the first frame update
    void Start()
    {
        _speedValue = 0;
        _scoreValue = 0;
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        //cube.GetComponent<Renderer>().material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && _speedValue <=20)
        {
            _speedValue += 7;
        }

        else if (Input.GetKeyDown(KeyCode.D) && _speedValue > 0)
        {
            _speedValue -= 7;
        }

        else if (_speedValue > 20)
        {
            Debug.Log("WOW Slow down man! Press D key, please");
        }

        else if (_speedValue <= 0)
        {
            Debug.Log("You need to speed up man! Press S key, please");
        }

        else
        {
            Debug.Log("Press S or D to move");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _scoreValue += 10;

            if (_scoreValue >= 50)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.green;
                //cube.GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
}
