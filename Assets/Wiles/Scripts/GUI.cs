using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Wiles
{
    public class GUI : MonoBehaviour
    {

        public GameObject gameRef;
        GameValues gameScore;

        public Text gameInfo;

        // Start is called before the first frame update
        void Start()
        {
            gameScore = gameRef.GetComponent<GameValues>();

        }

        // Update is called once per frame
        void Update()
        {
            gameInfo.text = $"Score: \n" +
                $"{gameScore.score} \n" +
                $"Multiplyer: \n" +
                $"{gameScore.multiplyer} \n" +
                $"Balls Left: \n" +
                $"{gameScore.ballsLeft} \n";
            if (gameScore.gameOver) gameInfo.text += $"GAMEOVER!";
        }
    }
}
