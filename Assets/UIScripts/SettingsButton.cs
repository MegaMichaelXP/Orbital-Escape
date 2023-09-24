using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsButton : MonoBehaviour
{
    Button MenuButton;
    GameObject MainMenu;
    GameObject SettingsMenu;
    MenuController MenuCont;
    SettingsController Settings;
    // Start is called before the first frame update
    void Awake()
    {
        MenuButton = gameObject.GetComponent<Button>();
        MenuButton.onClick.AddListener(OpenSettingsMenu);
        MainMenu = GameObject.FindWithTag("Menu");
        SettingsMenu = GameObject.Find("SettingsMenu");
        Settings = SettingsMenu.GetComponent<SettingsController>();
    }

    void OpenSettingsMenu()
    {
        Settings.LoadValues();
        MainMenu.SetActive(false);
        SettingsMenu.SetActive(true);
    }
}
