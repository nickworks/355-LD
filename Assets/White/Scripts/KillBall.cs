using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace White
{
    public class KillBall : MonoBehaviour
    {
        public float killPlane;
        public GameObject ball;
        
        void Update()
        {
            if (ball.transform.position.z < killPlane)
            {
                Destroy(ball);
            }
        }
    }
}