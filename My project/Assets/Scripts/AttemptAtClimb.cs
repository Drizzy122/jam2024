using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AttemptAtClimb : MonoBehaviour
{
    public List<KeyCode> ClimbingInputs;
    public List<KeyCode> ClimbingOutputs;
    public int NumberOfClimbingOutputs;
    public CorrectLetter[] ClimbingLetters;
    public GameObject rockPrefab;

    // Start is called before the first frame update
    void Start()
    {
        RandomiseClimbingPoints(NumberOfClimbingOutputs);

        Times(NumberOfClimbingOutputs);
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
    public void Times(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Spawn();
        }
        //AssignLetters();
    }
    public void Spawn()
    {
        
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-25, 25), (Random.Range(0, 70)), 5);
            Instantiate(rockPrefab, randomSpawnPosition, Quaternion.identity);
        
    }

    public void ReAssighn()
    {

        for (int i = 0; i < ClimbingLetters.Length;i++)
        {
            ClimbingLetters[i].AssignLetter(ClimbingOutputs[i]);
        }
    }
}
