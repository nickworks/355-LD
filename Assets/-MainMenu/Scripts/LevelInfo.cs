using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable()]
public class LevelInfo {
    public string levelName;
    public string levelFilename;
    public string studentName;
    public Sprite buttonSprite;
    public Color buttonTextColor = Color.black;
    public string splashScreenComments;
    public Sprite splashScreenImage;
    public Transform splashScreenPrefab;
}
