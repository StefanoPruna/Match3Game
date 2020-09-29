using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;//Needed to declare Func

public class ReturnDelegate : MonoBehaviour
{
    public Func<string, int> CharacterLength;

    public Func<int> onGetName;

    // Start is called before the first frame update
    void Start()
    {
        CharacterLength = GetCharacters;
        int count = CharacterLength("Loske");
        Debug.Log("Count: " + count);

        onGetName = () => this.gameObject.name.Length;//Lambda coding
        int characterCount = onGetName();
        Debug.Log("Character Count: " + characterCount);
    }

    int GetCharacters(string name)
    {
        return name.Length;
    }
}
