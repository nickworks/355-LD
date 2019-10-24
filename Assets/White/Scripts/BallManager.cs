using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace White {
    public class BallManager : MonoBehaviour
    {
        public static int ballsLeft;
        Text text;

        void Start()
        {
            text = GetComponent<Text>();
            ballsLeft = 2;
        }

        void Update()
        {
            text.text = "Balls Left: " + ballsLeft;

            if (KillBall.ballIsDead)
            {
                ballsLeft--;
                if(ballsLeft < 0)
                {
                    ballsLeft = 0;
                }
            }
        }
    }
}