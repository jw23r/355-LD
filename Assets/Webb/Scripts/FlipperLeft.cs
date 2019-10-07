﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperLeft : MonoBehaviour
{
    Rigidbody body;
    HingeJoint joint;
    public float capultSrentgh = 300;

    public

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        joint = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("FlipperLeft"))
        {
            JointSpring spring = new JointSpring();
            spring.targetPosition = -65;
            spring.spring = capultSrentgh;
            joint.spring = spring;
            joint.useSpring = true;



        }
        if (Input.GetButtonUp("FlipperLeft"))
        {
            JointSpring spring = new JointSpring();
            spring.targetPosition = 20;
            spring.spring = capultSrentgh;
            joint.spring = spring;
            joint.useSpring = true;



        }
    }

}