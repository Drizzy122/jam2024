using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
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
    private Collider rocksIn;
    public AttemptAtClimb data;
    public float WaitRock;


    // Start is called before the first frame update
    void Start()
    {
        playa = GameObject.FindGameObjectWithTag("Player");
        Player = playa.GetComponent<Transform>();
        RockH = gameObject.GetComponent<Transform>();
        data = GameObject.FindAnyObjectByType<AttemptAtClimb>();
        AssignTags();
        
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Player)
        {
            float dist = Vector3.Distance(Player.position, RockH.position);
            if (dist < 0.2f)
            {
                isgrabable = false;
                StartCoroutine(Rockfall());
                // Make a Fail cehck code in here // collider or some shit could do

            }
        }
        if (Input.GetKeyDown(myKey) & isgrabable)
        {

            Debug.Log(myKey.ToString());
            Player.position = RockH.position;


        }

    }
    IEnumerator Rockfall()
    {
        yield return new WaitForSeconds(WaitRock);
        gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }

    public void AssignTags()
    {
        if (myKey == KeyCode.W)
        {
            gameObject.tag = "W";
        }
        if (myKey == KeyCode.R)
        {
            gameObject.tag = "R";
        }
        if (myKey == KeyCode.E)
        {
            gameObject.tag = "E";
        }
        if (myKey == KeyCode.Q)
        {
            gameObject.tag = "Q";
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        isgrabable = true; 
       
        if (other.gameObject.CompareTag(this.gameObject.tag))
        {
            Debug.Log($"is sees the same tag");

            data.ReAssighn();
        }

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
