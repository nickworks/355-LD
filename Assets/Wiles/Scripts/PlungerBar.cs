using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlungerBar : MonoBehaviour
{

    public Image progressBar;
    public Text progressText;

    float power;
    float powerMax;

    public GameObject pinballReference;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        power = pinballReference.GetComponent<BallLauncher>().force;
        powerMax = pinballReference.GetComponent<BallLauncher>().maxForce;

        progressBar.fillAmount = power / powerMax;
        progressText.text = $"{progressBar.fillAmount * 100}%";
    }
}
