using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text activeEnemiesText;

    public void UpdateEnemyCount()
    {
        activeEnemiesText.text = "Active Enemies: " + SpawnManager.enemyCount;
    }
    public void OnEnable()
    {
        //PlayerActions.onDemage += UpdateHealth;//To use with delegate
        PlayerActions.onDamageReceived += UpdateHealth;//to use with action
    }
    public void UpdateHealth(int health)
    {
        Debug.Log("Current Health: " + health);
    }

}
