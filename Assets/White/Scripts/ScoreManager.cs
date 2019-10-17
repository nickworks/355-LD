using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace White
{
    public class ScoreManager : MonoBehaviour
    {
        public static int score;
        Text text;

        void Start()
        {
            text = GetComponent<Text>();
            score = 0;
        }
        
        void Update()
        {

            text.text = "Score: " + score;
        }
    }
}