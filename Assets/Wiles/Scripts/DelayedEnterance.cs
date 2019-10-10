using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wiles
{
    public class DelayedEnterance : MonoBehaviour
    {

        public float delayTimer;
        public Vector3 startingOffset;
        Rigidbody body;
        bool iWantToMove = false;
        bool canIMove = false;
        Vector3 startingPosition;
        public enum Trigger { Plunger, LeftFlipper, RightFlipper };
        public Trigger trigger;

        // Start is called before the first frame update
        void Start()
        {
            body = GetComponent<Rigidbody>();
            startingPosition = transform.position;
            Vector3 startMove = transform.position + startingOffset;
            transform.position = startMove;
        }

        // Update is called once per frame
        void Update()
        {
            switch (trigger)
            {
                case Trigger.Plunger:
                    if (Input.GetButtonUp("Plunger")) iWantToMove = true;
                    break;
                case Trigger.LeftFlipper:
                    if (Input.GetButtonUp("FlipperLeft")) iWantToMove = true;
                    break;
                case Trigger.RightFlipper:
                    if (Input.GetButtonUp("FlipperRight")) iWantToMove = true;
                    break;
                default:
                    break;
            }
            if (iWantToMove) delayTimer = delayTimer - Time.deltaTime;
            if (delayTimer <= 0)
            {
                canIMove = true;
                delayTimer = 0;
            }
            if (canIMove) transform.position = Vector3.Lerp(transform.position, startingPosition, .01f);
        }
    }
}