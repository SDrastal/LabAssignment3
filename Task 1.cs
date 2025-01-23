using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //Name of the class that will be calculated
    [SerializeField]
    private string className = "Science";

    [SerializeField, Range(0, 10)]
    private int numberOfModules = 0;

    [SerializeField, Range(0, 10)]
    private int numberOfReadingMaterial = 0;

    [SerializeField, Range(0, 10)]
    private int numberOfQuizes = 0;

    [SerializeField, Range(0, 10)]
    private int numberOfAssignments = 0;

    [SerializeField]
    private bool hasInstructorTaughtCourse = false;
    
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log($"The name of the class is {className}.");


        float difficulty = 0;
        //add percentage scaled by number for each category
        difficulty += ChallengeCalculator(15, numberOfModules);
        difficulty += ChallengeCalculator(30, numberOfReadingMaterial);
        difficulty += ChallengeCalculator(15, numberOfQuizes);
        difficulty += ChallengeCalculator(30, numberOfAssignments);

        //if instructor has not taught class, give 10 % difficulty
        difficulty += ChallengeCalculator(10, (hasInstructorTaughtCourse) ? 0 : 10);

        Debug.Log($"Its total difficulty is {difficulty}%");
    }

    //multiply total percentage by scalar from 0-10.
    float ChallengeCalculator (float percentage, int difficulty)
    {
        return percentage * (difficulty/10f);
    }


}