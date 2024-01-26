using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class badRock : MonoBehaviour
{
    public KeyCode myKey;
    public TextMeshPro myLetter;
    public Transform Player;
    private Transform RockH;
    public bool isgrabable;
    public float WaitRock;
    private GameObject playa;
    // Start is called before the first frame update
    void Start()
    {
        
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isgrabable = true;

        }

    }
    private void OnTriggerExit(Collider other)
    {
        isgrabable = false;
    }
    public void AssignLetter(KeyCode LetterToAssign)
    {
        myKey = LetterToAssign;
       // AssignTags(LetterToAssign);
        myLetter.text = myKey.ToString();
    }
}
