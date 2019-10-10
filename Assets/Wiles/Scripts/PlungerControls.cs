using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wiles
{
    public class PlungerControls : MonoBehaviour
    {

        ConfigurableJoint joint;
        Vector3 defaultPosition;
        enum PlungerState { Rest, Pull, Launch };
        PlungerState currentState;

        // Start is called before the first frame update
        void Start()
        {
            joint = GetComponent<ConfigurableJoint>();
            defaultPosition = joint.connectedAnchor;
            currentState = PlungerState.Rest;
        }

        // Update is called once per frame
        void FixedUpdate()
        {

            switch (currentState)
            {

                case PlungerState.Rest:
                    float newZ = (joint.connectedAnchor.z * defaultPosition.z) / 2;
                    Vector3 defPos = Vector3.Lerp(joint.connectedAnchor, defaultPosition, 0.1f);
                    joint.connectedAnchor = defPos;

                    if (Input.GetButtonDown("Plunger")) currentState = PlungerState.Pull;
                    break;

                case PlungerState.Pull:
                    float newZ2 = joint.connectedAnchor.z * 0.9f;
                    Vector3 pullBack = new Vector3(joint.connectedAnchor.x, joint.connectedAnchor.y, newZ2);
                    joint.connectedAnchor = pullBack;

                    if (Input.GetButtonDown("Plunger")) currentState = PlungerState.Launch;
                    break;

                case PlungerState.Launch:
                    float newZ3 = (joint.connectedAnchor.z + 2f) / 2;
                    Vector3 launchOut = new Vector3(joint.connectedAnchor.x, joint.connectedAnchor.y, newZ3);
                    joint.connectedAnchor = launchOut;

                    if (Input.GetButtonDown("Plunger")) currentState = PlungerState.Rest;
                    break;
            }
            /*
            float p = Input.GetAxis("Plunger");
            print(p);
            if (p > 0)
            {

            }
            print(Input.GetButtonUp("Plunger"));
            if (Input.GetButtonUp("Plunger"))
            {

            }
            */
        }
    }
}