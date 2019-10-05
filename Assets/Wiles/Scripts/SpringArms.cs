using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringArms : MonoBehaviour
{

    public GameObject leftArm;
    public GameObject rightArm;

    HingeJoint targetLeft;
    HingeJoint targetRight;

    JointSpring targetSpringLeft;
    JointSpring targetSpringRight;

    // Start is called before the first frame update
    void Start()
    {
        targetLeft = leftArm.GetComponent<HingeJoint>();
        targetRight = rightArm.GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        //HingeJoint leftSpring = 
        //HingeJoint rightSpring = 

        //leftSpring.spring = targetLeft.spring;
        //rightSpring.spring = targetRight.spring;

        targetSpringLeft = targetLeft.spring;
        targetSpringRight = targetRight.spring;

        targetSpringLeft.targetPosition = 0;
        targetSpringRight.targetPosition = 0;

        float d = Input.GetAxis("Horizontal");
        if (d < 0) { // Left is pushed...
            // Activete Left Arms...
            print("LEFT!");
            targetSpringLeft.targetPosition = -90;
        }
        if (d > 0){ // Right is pushed...
            // Activate Right Arms...
            print("RIGHT!");
            targetSpringRight.targetPosition = 90;
        }
        
        targetLeft.spring = targetSpringLeft;
        targetRight.spring = targetSpringRight;

        //leftArm = targetLeft;
        //rightArm = targetRight;
        
    }
}
