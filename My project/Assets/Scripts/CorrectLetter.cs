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
    public bool isgrabable;
    //public GrabCloseRock grab;

    // Start is called before the first frame update
    void Start()
    {
       // Player = GameObject.FindWithTag("Player");
        RockH = gameObject.GetComponent<Transform>();
        //grab = gameObject.GetComponent<GrabCloseRock>();
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(myKey) & isgrabable)
        {
            Debug.Log(myKey.ToString());
            Player.position = RockH.position;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        isgrabable = true;
    }

    public void AssignLetter(KeyCode LetterToAssign)
    {
        myKey = LetterToAssign;
        myLetter.text = myKey.ToString();
    }
}
