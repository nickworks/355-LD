using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiplierManager : MonoBehaviour
{
    public static int multiplier;
    Text text;
    
    void Start()
    {
        text = GetComponent<Text>();
        multiplier = 0;
    }
    
    void Update()
    {
        text.text = "Multi: " + multiplier;
    }
}
