using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerType 
{
    //THESE ARE INSTANCE MEMBERS; EACH PLAYER WILL HAVE THE 4 VAR BELOW
    public int id;
    public string playername;
    public string classCharacter;
    public string race;

    //THIS IS A STATIC MEMBER; IT WILL ONLY COUNT HOW MANY PLAYERS THERE ARE, IN THIS CASE 3
    public static int playerCount;

    public PlayerType()
    {
        playerCount++;
    }
}

public class Players : MonoBehaviour
{
    private void Start()
    {
        PlayerType p1 = new PlayerType();
        PlayerType p2 = new PlayerType();
        PlayerType p3 = new PlayerType();

        Debug.Log("Players in the game at the moment: " + PlayerType.playerCount);
    }
}
