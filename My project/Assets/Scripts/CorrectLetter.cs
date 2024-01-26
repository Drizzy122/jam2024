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
    public AttemptAtClimb data;
    public float WaitRock;
    public GameObject RockBad;
    private Vector3 Where;
    public bool Withinreach;
    private badRock badRockScript;


    // Start is called before the first frame update
    void Start()
    {
        
        playa = GameObject.FindGameObjectWithTag("Player");
        Player = playa.GetComponent<Transform>();
        RockH = gameObject.GetComponent<Transform>();
        // data = GameObject.FindAnyObjectByType<AttemptAtClimb>();
        badRockScript = RockBad.GetComponent<badRock>();
       
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
        if (Withinreach)
        {
          //  Detected();

        }

    }
    IEnumerator Rockfall()
    {
        yield return new WaitForSeconds(WaitRock);
        gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }

    public void AssignTags(KeyCode LetterToAssign)
    {
        if (myKey == LetterToAssign)
        {
            gameObject.tag = LetterToAssign.ToString();
        }
        /*
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
        */
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
        isgrabable = true; 

        }
       
        if (other.gameObject.CompareTag(this.gameObject.tag))
        {
            Withinreach = true;
           Detected();
        }

    }
    private void OnTriggerExit(Collider other)
    {
        isgrabable = false;
    }

    public void AssignLetter(KeyCode LetterToAssign)
    {
        myKey = LetterToAssign;
        AssignTags(LetterToAssign);
        myLetter.text = myKey.ToString();
    }
    public void ChangeRock()
    {
        Vector3 thisRock = gameObject.transform.position;
        Instantiate(RockBad, thisRock, Quaternion.identity);
        gameObject.SetActive(false);
      //  badRockScript.AssignLetter(myKey);
        

    }
    public void Detected()
    {
        data = GameObject.FindAnyObjectByType<AttemptAtClimb>();
        Debug.Log($"is sees the same tag");

        data.ReAssighn();
        ChangeRock();
        Withinreach = false;
    }
}
