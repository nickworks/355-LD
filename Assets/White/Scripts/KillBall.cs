using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace White
{
    public class KillBall : MonoBehaviour
    {
        public float killPlane;
        public GameObject ball;
        public bool ballIsDead = true;
        
        void Update()
        {
            if (ball.transform.position.z < killPlane)
            {
                ballIsDead = true;
                Destroy(ball);
            }

            ballIsDead = false;
        }
    }
}