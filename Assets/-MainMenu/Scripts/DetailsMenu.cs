using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DetailsMenu : MonoBehaviour
{
    public MainMenuCameraControl sceneCamera;
    public Image detailsImage;
    public Text detailsComments;

    Transform splashScreenScene;
    EventSystem events;
    LevelInfo level;
    void Start() {
        events = GetComponentInChildren<EventSystem>();
    }
    public void Init(LevelInfo level) {
        this.level = level;
        detailsImage.sprite = level.splashScreenImage;
        detailsComments.text = 
            $"<size=40><color=white>{level.levelName}</color>\n<color=#888>{level.studentName}</color></size>\n{level.splashScreenComments}";
        if (level.splashScreenPrefab)
            splashScreenScene = Instantiate(level.splashScreenPrefab, transform, true); // spawn prefab, as a child of this object
    }
    void Update() {
        if (!sceneCamera.lookAtLevelDetails) {
            if (splashScreenScene != null) Destroy(splashScreenScene.gameObject);
            return;
        }
        Focus();
    }
    void Focus() {
        if (events != null && events.currentSelectedGameObject == null) {
            events.SetSelectedGameObject(events.firstSelectedGameObject);
        }
    }
    public void ButtonClickPlay() {
        if (level == null) return;
        SceneManager.LoadScene(level.levelFilename, LoadSceneMode.Single);
    }
    public void ButtonClickBack() {
        sceneCamera.lookAtLevelDetails = false;
    }
}
