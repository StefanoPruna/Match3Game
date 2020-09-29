using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //to declare an ACTION

public class PlayerActions : MonoBehaviour
{
    /*public delegate void OnDamageReceived(int currentHealth);
    public static event OnDamageReceived onDemage;
    */
    //public Action onComplete; Whic is the same as= public delegate void onComplete, they are the same line of code
    public static Action<int> onDamageReceived;
    public int Health { get; set; }

    public Action onGetName;

    // Start is called before the first frame update
    void Start()
    {
        Health = 10;

        onGetName = () => //Lambda coding
        {
            Debug.Log("Name: " + gameObject.name);
        };
        onGetName();
    }

    void Damage()
    {
        Health--;
        //UIManager.UpdateHealth(health); from UIManager script
        /*if (onDemage != null)
            onDemage(Health); use with delegate*/
        if (onDamageReceived != null)
            onDamageReceived(Health);//Use with Actions
    }
}
