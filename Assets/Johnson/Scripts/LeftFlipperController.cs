using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Johnson
{
    public class LeftFlipperController : MonoBehaviour
    {

        HingeJoint leftHinge;

        void Start()
        {

            leftHinge = GetComponent<HingeJoint>();

        }


        void FixedUpdate()
        {

            if (Input.GetButton("FlipperLeft"))
            {
                leftHinge.useMotor = true;
            }
            else
            {
                leftHinge.useMotor = false;
            }

        }
    }
}
