using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace White
{
    /*
     * This class allows the player to charge up the plunger in order to launch the ball into play.
     */
    public class ChargePlunger : MonoBehaviour
    {
        Rigidbody body;
        SpringJoint joint;

        public float plungerStrength = 0;
        private Vector3 plungerStart;

        /*
         * This function gets the Rigidbody and stores it into its variable.
         */
        void Start()
        {
            body = GetComponent<Rigidbody>();
            joint = GetComponent<SpringJoint>();
            plungerStart = body.position;
        }

        /*
         * This function updates the plunger.
         */
        void FixedUpdate()
        {
            if (Input.GetButton("Plunger"))
            {
                body.MovePosition(body.position + Vector3.back * Time.deltaTime); // move the plunger's position back while the space bar is pressed down

                plungerStrength += 1000 * Time.deltaTime;
                plungerStrength = Mathf.Clamp(plungerStrength, 0, 10000);
            }

            if (Input.GetButtonUp("Plunger"))
            {
                plungerStrength = 0;
                //body.position = plungerStart;
            }
        }
    }
}