using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFlipperController : MonoBehaviour
{

    HingeJoint rightHinge;

    void Start()
    {
        rightHinge = GetComponent<HingeJoint>();
    }

    
    void FixedUpdate()
    {

        if (Input.GetButton("FlipperRight"))
        {
            rightHinge.useMotor = true;
        }
        else
        {
            rightHinge.useMotor = false;
        }

    }
}
