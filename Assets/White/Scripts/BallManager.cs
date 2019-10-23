using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace White {
    public class BallManager : MonoBehaviour
    {
        public GameObject ball;
        public float killPlane;
        public bool isDead = false;

        public static int ballsLeft;
        Text text;

        void Start()
        {
            text = GetComponent<Text>();
            ballsLeft = 2;
        }

        void Update()
        {
            BallIsDead();

            if (isDead) LoseBall();

            text.text = "Balls Left: " + ballsLeft;
        }

        public void BallIsDead()
        {
            if (ball != null && ball.transform.position.z < killPlane)
            {
                isDead = true;
                Destroy(ball);
            }
        }

        public static void LoseBall()
        {
            ballsLeft--;
            if (ballsLeft < 0) ballsLeft = 0;
        }
    }
}