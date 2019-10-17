using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Johnson
{
    public class PlungerImpulse : MonoBehaviour
    {

        float counter;
        float counterMax = 5.0f;
        public GameObject plunger;
        public Rigidbody body;
        bool isTouching = false;
        Vector3 originalPos;
        Vector3 newPos;
        Vector3 movement;


        private void Start()
        {
            originalPos = body.transform.position;
            
        }


        private void FixedUpdate()
        {
            if (Input.GetButtonDown("Plunger"))
            {
                counter = 0;
            }
            if (Input.GetButton("Plunger"))
            {
                movement.z -= .01f;
                plunger.transform.position = movement;

                if (counter > counterMax)
                {
                    counter = counterMax;
                }
                else
                {
                    plunger.transform.position = originalPos;
                    counter += .04f;
                }

            }
            else if (Input.GetButtonUp("Plunger"))
            {
                if (isTouching)
                {
                    body.AddForce(Vector3.forward * counter, ForceMode.Impulse);
                }
            }

        }
        private void OnTriggerEnter(Collider other)
        {
            isTouching = true;
        }

        private void OnTriggerExit(Collider other)
        {
            isTouching = false;
        }
    }
}
