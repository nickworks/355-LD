using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace White {
    public class BallManager : MonoBehaviour
    {
        public GameObject ball;

        bool stopSpawning = false;

        public float killPlane;
        bool isDead = false;

        public int ballsLeft = 2;
        Text text;

        void Start()
        {
            text = GetComponent<Text>();
        }

        void Update()
        {
            BallIsDead();

            if (isDead) LoseBall();

            text.text = "Balls Left: " + ballsLeft;
        }

        public void Spawn()
        {
            Instantiate(ball, transform.position, transform.rotation);
            isDead = false;
            stopSpawning = true;
            if (stopSpawning)
            {
                isDead = false;
                CancelInvoke("Spawn");
            }

            if (isDead == true)
            {
                Invoke("Spawn", 5);
            }
        }

        public void BallIsDead()
        {
            if (ball != null && ball.transform.position.z < killPlane)
            {
                isDead = true;
                Destroy(ball);
            }
        }

        public void LoseBall()
        {
            ballsLeft--;
            if (ballsLeft < 0) ballsLeft = 0;
        }
    }
}