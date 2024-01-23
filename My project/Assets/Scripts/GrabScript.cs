using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GrabScript : MonoBehaviour
{
    public Transform Player;
    private CorrectLetter letter;
    public TextMeshPro myLetter;

    // Start is called before the first frame update
    void Start()
    {
        CorrectLetter letter = GetComponent<CorrectLetter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(letter.myKey))
        {
            Debug.Log(myLetter.text);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        CorrectLetter letter = other.GetComponent<CorrectLetter>();
        Transform where = other.transform;
        if (Input.GetKeyDown(letter.myKey))//letter.myKey))
        {
            Debug.Log($"myKey.ToString()");
          gameObject.transform.position = where.position;
        }
       




    }
}
