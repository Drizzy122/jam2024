using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CorrectLetter : MonoBehaviour
{
    public KeyCode myKey;
    public TextMeshPro myLetter;
    public Transform Player;
    private Transform RockH;
    public bool isgrabable;
    private GameObject playa;
    

    // Start is called before the first frame update
    void Start()
    {
        playa = GameObject.FindGameObjectWithTag("Player");
        Player = playa.GetComponent<Transform>();
        RockH = gameObject.GetComponent<Transform>();
        
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
    private void OnTriggerExit(Collider other)
    {
        isgrabable = false;
    }

    public void AssignLetter(KeyCode LetterToAssign)
    {
        myKey = LetterToAssign;
        myLetter.text = myKey.ToString();
    }
}
