using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LinqChallengeOne : MonoBehaviour
{
    public int[] quizGrades = { 2, 34, 45, 56, 76, 88, 99 };

    // Start is called before the first frame update
    void Start()
    {
        var passGrades = quizGrades.Where(grades => grades > 69).OrderByDescending(grades => grades).Reverse();
        foreach (var newList in passGrades)
        {
            Debug.Log("Grades passed: " + newList);
        }
    }
}
