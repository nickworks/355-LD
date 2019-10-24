using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace webb
{
    public class FlipperRight : MonoBehaviour
    {
        Rigidbody body;
        HingeJoint joint;
        public float capultSrentgh = .0000000000001f;

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
            Flipper();
        }

        private void Flipper()
        {
            if (Input.GetButtonDown("FlipperRight"))
            {
                JointSpring spring = new JointSpring();
                if (MatChanger.wood == true)
                {
                    spring.targetPosition = 65;
                }
                else
                {
                    spring.targetPosition = 5;
                }
                spring.spring = capultSrentgh;
                joint.spring = spring;
                joint.useSpring = true;



            }
            if (Input.GetButtonUp("FlipperRight"))
            {
                JointSpring spring = new JointSpring();
                spring.targetPosition = -20;
                spring.spring = capultSrentgh;
                joint.spring = spring;
                joint.useSpring = true;



            }
        }
    }
}