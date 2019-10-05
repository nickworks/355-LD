using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This class enables the player to control the left flipper.
 */
public class LeftFlipperControl : MonoBehaviour
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
     * This function updates the left flipper to move when the left mouse button is pressed.
     */
    void Update()
    {
        JointSpring spring = new JointSpring();

        if (Input.GetButton("FlipperLeft"))
        {
            flipperStrength = +200 * Time.deltaTime;
            flipperStrength = Mathf.Clamp(flipperStrength, 0, 1000);

            spring.targetPosition = -90;
            spring.spring = flipperStrength;

            joint.spring = spring;
            joint.useSpring = true;
        }

        if (Input.GetButtonUp("FlipperLeft"))
        {
            joint.useSpring = false;
            flipperStrength = 0;
            spring.targetPosition = 90;
        }
    }
}
