using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Johnson
{
    public class UIController : MonoBehaviour
    {

        public Text ballsLeftText;
        public Text scoreText;
        public Image plungerSpring;

        int ballsLeftNum = 3;
        int scoreNum = 0;
        float plungerStrength = 0;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            scoreText.text = ("Score: " + scoreNum);
            ballsLeftText.text = ("Balls Left: " + ballsLeftNum);
            

            /*if (Input.GetButton("Plunger"))
            {
                
            }*/
        }

            }
}
