using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabCloseRock : MonoBehaviour
{
    private CorrectLetter letter;
    public bool isgrabable;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnTriggerExit(Collider other)
    {
        isgrabable = false;
    }
}
