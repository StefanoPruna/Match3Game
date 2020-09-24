using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectDifficulty : MonoBehaviour
{
    public enum LevelSelector
    {
        Easy,
        Normal,
        Hard,
        Expert
    }

    public LevelSelector selectedDifficulty;

    private void Start()
    {
        SceneManager.LoadScene((int)selectedDifficulty);

        switch(selectedDifficulty)
        {
            case LevelSelector.Easy:
                break;
            case LevelSelector.Normal:
                break;
            case LevelSelector.Hard:
                break;
            case LevelSelector.Expert:
                break;
        }
    }
}
