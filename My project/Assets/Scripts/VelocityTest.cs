using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityTest : MonoBehaviour
{
    
    public Rigidbody rb;
    public Transform target;
    public float stoppingDist;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = target.position;
        Vector3 currentPos = transform.position;
        float distance = Vector3.Distance(currentPos, targetPos);
        if (distance > stoppingDist)
        {
            Vector3 directionOfGo = targetPos - currentPos;
            directionOfGo.Normalize();
            rb.MovePosition(currentPos + (directionOfGo * speed * Time.deltaTime));
        }


    }
}

        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(0, 100 , 0);
        }
        */