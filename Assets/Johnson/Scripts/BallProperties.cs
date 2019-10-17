using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Johnson
{
    public class BallProperties : MonoBehaviour
    {
        public Rigidbody body;
        Collision ball;
        Vector3 direction;
        public int mag;

        private void Start()
        {
            direction = body.velocity;

        }
    }
}
