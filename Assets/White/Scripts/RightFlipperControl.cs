using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This class enables the player to control the right flipper.
 */
public class RightFlipperControl : MonoBehaviour
{
    Rigidbody body;
    HingeJoint joint;
    public float flipperStrength = 0;

    /*
     * This function obtains the Rigidbody and SpringJoint and stores them in their respective variables.
     */
    void Start()
    {
        body = GetComponent<Rigidbody>();
        joint = GetComponent<HingeJoint>();
    }

    /*
     * This function updates the right flipper to move when the right mouse button or the right shift key is pressed.
     */
    void Update()
    {
        JointSpring spring = new JointSpring();

        if (Input.GetButton("FlipperRight"))
        {
            spring.targetPosition = 75;
            spring.spring = flipperStrength;

            joint.spring = spring;
            joint.useSpring = true;
        }

       if(Input.GetButtonUp("FlipperRight"))
        {
            spring.targetPosition = 0;
            spring.spring = flipperStrength;

            joint.spring = spring;
        }
    }
}
