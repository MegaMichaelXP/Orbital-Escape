using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeButton : MonoBehaviour
{
    Button MenuButton;
    CameraController Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player").GetComponent<CameraController>();
        MenuButton = gameObject.GetComponent<Button>();
        MenuButton.onClick.AddListener(ResumeGame);
    }

    void ResumeGame()
    {
        Player.UnpauseGame();
    }
}
