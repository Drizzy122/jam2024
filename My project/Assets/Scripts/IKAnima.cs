using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKAnima : MonoBehaviour
{
    public Transform targetTransform;
    private Animator animator;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnAnimatorIK()

    {
        animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
        animator.SetIKPosition(AvatarIKGoal.LeftHand, targetTransform.position);
    }
}
