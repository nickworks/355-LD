using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace webb
{
    public class HUDControler : MonoBehaviour
    {
        // Start is called before the first frame update
        public Image progressBar;
        float xp = 0;
        float xpMax = 350;
        public Text textScore;
        public Text textLives;
        public Text textMultiplier;
        public static int score;
        public static int lives;
        public static int multiplier;
        void Start()
        {
            score = 0;
            lives = 3;
            multiplier = 1;
        }

        // Update is called once per frame
        void Update()
        {
            HUD();
        }

        private void HUD()
        {
            textScore.text = $"SCORE:{(int)score}";
            textLives.text = $"Lives:{(int)lives}";
            textMultiplier.text = $"X{(int)multiplier}";
            if (Input.GetButton("Plunger"))
            {
                xp += 200 * Time.deltaTime;
                float p = xp / xpMax;


            }
            progressBar.fillAmount = xp / xpMax;
            if (Input.GetButtonUp("Plunger"))
            {
                ClearXpValue();
            }
        }

        public void ClearXpValue()
        {
            xp = 0;
        }
    }
}