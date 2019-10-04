using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuButton : MonoBehaviour, IPointerEnterHandler {

    public delegate void MainMenuButtonClicked();

    public Vector2 bigSize = new Vector2(400, 80);

    LevelInfo level;
    MainMenuButtonClicked callback;

    Image img;

    void Start() {
        
    }
    public Vector2 GetSize() {
        return (transform as RectTransform).rect.size;
    }
    public MainMenuButton Init(LevelInfo level, MainMenuButtonClicked callback) {

        this.level = level;
        this.callback = callback;

        Text text = GetComponentInChildren<Text>();
        text.text = level.levelName;
        text.color = level.buttonTextColor;

        if (level.buttonSprite != null) {
            Image img = GetComponent<Image>();
            if (img != null) img.sprite = level.buttonSprite;
        }

        (transform as RectTransform).SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, bigSize.x);
        (transform as RectTransform).SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, bigSize.y);

        return this;
    }
    public MainMenuButton Init(string caption, MainMenuButtonClicked callback) {
        this.callback = callback;

        Text text = GetComponentInChildren<Text>();
        text.text = caption;

        return this;
    }
    public void Focus() {

        Button bttn = GetComponent<Button>();
        if (bttn != null) bttn.Select();
    }
    public void Clicked() {
        if(callback != null) {
            callback();
        }
    }
    public void OnPointerEnter(PointerEventData eventData) {
        Focus();
    }
}
