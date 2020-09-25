using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    public int id;

    public Character(int id)
    {
        this.id = id;
    }
}

public class PlayerDictionary : MonoBehaviour
{
    /*public Dictionary<int, Character> characterDictionary = new Dictionary<int, Character>();
    // Start is called before the first frame update
    void Start()
    {
        Character p1 = new Character(1);
        p1.name = "VictoriaBlu";
        Character p2 = new Character(50);
        p2.name = "Loske";
        Character p3 = new Character(18);
        p3.name = "Kitty";

        characterDictionary.Add(p1.id, p1);
        characterDictionary.Add(p2.id, p2);
        characterDictionary.Add(p3.id, p3);

        if (characterDictionary.ContainsValue(p3))
        {
            var item = characterDictionary[p3.id];
        }
    }*/

    public Dictionary<string, int> players = new Dictionary<string, int>();

    private void Start()
    {
        players.Add("Loske", 41);
        players.Add("VictoriaBlu", 35);
        players.Add("ObiWan", 3);

        int playerAge = players["Loske"];        
        Debug.Log("loske age is: " + playerAge);
        //int p2Age = players["VictoriaBlu"];
        Debug.Log("L'eta' di VictoriaBlu e': " + 35);
        
        foreach (KeyValuePair<string, int> player in players)
        {
            Debug.Log("The players" + player.Value);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
