using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Johnson
{
    public class HUDController : MonoBehaviour
    {

        public Image progressBar;
        public Text textXP;

        float xp = 0;
        float xpMax = 350;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            xp += 50 * Time.deltaTime;

            textXP.text = $"XP: {(int)xp}";
            progressBar.fillAmount = xp / xpMax;
        }

        public void ClearXPValue()
        {
            xp = 0;
        }
    }
}
