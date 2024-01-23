using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CorrectLetter : MonoBehaviour
{
    public KeyCode myKey;
    //public TextMesh myLetter;
    public TextMeshPro myLetter;
    public Transform Player;
    private Transform RockH;

    // Start is called before the first frame update
    void Start()
    {
       // Player = GameObject.FindWithTag("Player");
        RockH = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(myKey))
        {
            Debug.Log(myKey.ToString());
            Player.position = RockH.position;
        }
    }

        public void AssignLetter(KeyCode LetterToAssign)
    {
        myKey = LetterToAssign;
        myLetter.text = myKey.ToString();
    }
    private void OnTriggerStay(Collider other)
    {
        
        Transform where = other.transform;
        if (Input.GetKeyDown(myKey))
        {
            Debug.Log(myKey.ToString());
            gameObject.transform.position = where.position;
        }





    }
}
