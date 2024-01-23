using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectLetter : MonoBehaviour
{
    public KeyCode myKey;
    public TextMesh myLetter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AssignLetter(KeyCode LetterToAssign)
    {
        myKey = LetterToAssign;
        myLetter.text = myKey.ToString();
    }
}
