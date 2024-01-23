using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttemptAtClimb : MonoBehaviour
{
    public List<KeyCode> ClimbingInputs;
    public List<KeyCode> ClimbingOutputs;
    public int NumberOfClimbingOutputs;
    public CorrectLetter[] ClimbingLetters;

    // Start is called before the first frame update
    void Start()
    {
        RandomiseClimbingPoints(NumberOfClimbingOutputs);
        ClimbingLetters = GameObject.FindObjectsOfType<CorrectLetter>();
        AssignLetters();
    }

   public void RandomiseClimbingPoints (int numberOfPoints)
    {
        ClimbingOutputs.Clear();
        for(int i = 0; i < numberOfPoints; i++)
        {
            ClimbingOutputs.Add(ClimbingInputs[Random.Range(0, ClimbingInputs.Count)]);
        }
    }

    public void AssignLetters()
    {
        for(int i = 0;i < ClimbingLetters.Length;i++)
        {
            ClimbingLetters[i].AssignLetter(ClimbingOutputs[i]);
        }
    }
}
