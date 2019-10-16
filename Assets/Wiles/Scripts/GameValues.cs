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

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (gameOver)
            {
                //TODO: Run GameOver Script
                print("GAMEOVER!");
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
    }
}