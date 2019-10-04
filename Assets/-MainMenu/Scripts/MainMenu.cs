using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    [Tooltip("A reference to the scene's camera.")]
    public MainMenuCameraControl sceneCamera;

    [Tooltip("A reference to the details menu GUI.")]
    public DetailsMenu detailsMenu;

    [Tooltip("A prefab button to spawn for each level.")]
    public MainMenuButton prefabButton;

    [Tooltip("A list of all the levels to display on this screen.")]
    public LevelInfo[] levels;

    private List<MainMenuButton> bttns = new List<MainMenuButton>();
    
    EventSystem events;

    void Start() {
        events = GetComponentInChildren<EventSystem>();
        BuildMenu();
    }
    void BuildMenu() {
        foreach (LevelInfo level in levels) {
            bttns.Add(MakeButton().Init(level, () => {
                detailsMenu.Init(level);
                sceneCamera.lookAtLevelDetails = true;
            }));
        }
        bttns.Add(MakeButton().Init("Quit", () => { }));
    }
    MainMenuButton MakeButton() {
        int marginLeft = 10;
        int marginTop = 10;
        int buttonWidth = 420;
        int buttonHeight = 100;

        int y = marginTop;
        int x = marginLeft;

        if (bttns.Count > 0) {
            MainMenuButton lastBttn = bttns[bttns.Count - 1];

            int cols = 2;
            int col = bttns.Count % cols;
            int row = bttns.Count / cols;

            x = marginLeft + col * buttonWidth;
            y = marginTop + row * buttonHeight; 

        }
        
        MainMenuButton bttn = Instantiate(prefabButton, transform);
        (bttn.transform as RectTransform).anchoredPosition = new Vector2(x, -y);

        return bttn;
    }

    void Update() {
        if (sceneCamera.lookAtLevelDetails) return;
        Focus();
    }
    void Focus() {
        
        if(events.currentSelectedGameObject == null) {
            if (bttns.Count > 0) {
                events.SetSelectedGameObject(bttns[0].gameObject);
            }
        }
    }
}
