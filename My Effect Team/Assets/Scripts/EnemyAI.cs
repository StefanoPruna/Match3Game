using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public enum EnemyState
    {
        Patroling,
        Attacking,
        Chasing,
        Death
    }

    public EnemyState currentState;

    // Start is called before the first frame update
    void Start()
    {
        //currentState = EnemyState.Patroling;        
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case EnemyState.Patroling:
                Debug.Log("Petroling");
                if (Time.time > 5)
                {
                    currentState = EnemyState.Chasing;
                }
                break;
            case EnemyState.Attacking:
                Debug.Log("Attacking");
                break;
            case EnemyState.Chasing:
                Debug.Log("Chasing");
                break;
            case EnemyState.Death:
                Debug.Log("Dying");
                break;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            currentState = EnemyState.Attacking;
        }
    }
}
