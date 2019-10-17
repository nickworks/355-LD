using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Johnson
{
    public class BallStopper : MonoBehaviour
    {
        public Rigidbody ball;
        Vector3 originalPos;
        Vector3 originalVelocity;

        private void Start()
        {
            originalPos = ball.transform.position;
            originalVelocity = ball.velocity;
        }

        private void OnTriggerEnter(Collider other)
        {
            ball.velocity = originalVelocity;
            ball.transform.position = originalPos;
        }

    }
}
