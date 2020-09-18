using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private UIManager _ui;

    //THESE THREE METHODS OR FUNCTIONS ARE IMPLEMENTED IN THE INSPECTOR OR UNITY WITH THE MONOBEHAVIOUR AND CAN BE CALLED AUTOMATICALLY
    public void OnEnable()
    {
        SpawnManager.enemyCount++;
        _ui = GameObject.Find("UIManager").GetComponent<UIManager>();
        _ui.UpdateEnemyCount();
        OnDestroy();
    }

    public void OnDisable()
    {
        SpawnManager.enemyCount--;
        _ui.UpdateEnemyCount();
    }

    private void OnDestroy()
    {
        Destroy(this.gameObject, Random.Range(2, 6));
    }
}
