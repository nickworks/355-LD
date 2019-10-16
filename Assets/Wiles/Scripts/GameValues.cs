using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wiles
{
    public class GameValues : MonoBehaviour
    {
        public bool gameOver = false;

        public int score = 0;
        public int multiplyer = 1;
        public int ballsLeft = 2;

        public GameObject pinBall;
        BallReseter resetHelp;

        // Start is called before the first frame update
        void Start()
        {
            resetHelp = pinBall.GetComponent<BallReseter>();
        }

        // Update is called once per frame
        void Update()
        {
            if (gameOver)
            {
                //TODO: Run GameOver Script
                //print("GAMEOVER!");
                if (Input.GetKeyUp("g")) resetGame();
            }
        }

        public void scoreUp(int pointsGain)
        {
            score += pointsGain * multiplyer;
        }

        public void multUp(int multGain)
        {
            multiplyer += multGain;
        }

        public void resetGame()
        {
            gameOver = false;
            score = 0;
            multiplyer = 1;
            ballsLeft = 2;

            resetHelp.resetBallPosition();
            resetHelp.resetBallLauncher();
            
        }
    }
}