using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GrabScript : MonoBehaviour
{
    public Transform Player;
    public AttemptAtClimb button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        CorrectLetter letter = other.GetComponent<CorrectLetter>();
        Transform where = other.transform;
        if (Input.GetKeyDown(letter.myKey))
        {
          gameObject.transform.position = where.position;
        }
         

        


    }
}
