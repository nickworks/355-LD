using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDControler : MonoBehaviour
{
    // Start is called before the first frame update
    public Image progressBar;
    float xp = 0;
    float xpMax = 350;
    public Text textXp;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        xp += 50 * Time.deltaTime;
        float p = xp / xpMax;
        progressBar.fillAmount = xp / xpMax;
    textXp.text = $"XP:{(int)xp}";
    }
    public void ClearXpValue()
    {
        xp = 0;
    }
}
