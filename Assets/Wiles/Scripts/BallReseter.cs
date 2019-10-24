using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wiles
{
    public class BallReseter : MonoBehaviour
    {

        public GameObject game;
        GameValues gameScore;

        // Start is called before the first frame update
        void Start()
        {
            gameScore = game.GetComponent<GameValues>();
        }

        // Update is called once per frame
        void Update()
        {
            if (gameScore == null) gameScore = game.GetComponent<GameValues>();
        }
        void OnCollisionEnter(Collision col)
        {
            var ob = col.gameObject;
            //print(ob);
            var wallHit = ob.GetComponent<BallReseterWall>();
            if (wallHit == null)
            {
                return;
            }
            else
            {
                if (wallHit.moveWhileReset)
                {
                    if (gameScore.ballsLeft <= 0)
                    {
                        gameScore.gameOver = true;
                        return;
                    }
                    else gameScore.ballsLeft--;

                    resetBallPosition();
                }
                resetBallLauncher();
            }
        }

        public void resetBallPosition()
        {
            transform.SetPositionAndRotation(new Vector3(0.243f, 0.03f, -0.4f), new Quaternion());
        }

        public void resetBallLauncher()
        {
            var bLauncher = GetComponent<BallLauncher>();
            bLauncher.Reset();
        }
    }
}