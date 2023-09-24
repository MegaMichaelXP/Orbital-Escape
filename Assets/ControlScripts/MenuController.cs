using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    GameObject MainMenu;
    GameObject SettingsMenu;
    GameObject[] SecondaryMenus;

    SettingsController Settings;

    SensitivityFactorSlider SFSlider;
    SoundVolumeSlider SVSlider;
    MusicVolumeSlider MVSlider;

    void Awake()
    {
        MainMenu = GameObject.FindWithTag("Menu");
        SettingsMenu = GameObject.Find("SettingsMenu");
        Settings = SettingsMenu.GetComponent<SettingsController>();
    }

    void Start()
    {
        //MainMenu.SetActive(true);
        //SettingsMenu.SetActive(false);
    }

    public void GoToMainMenu()
    {
        MainMenu.SetActive(true);
        SettingsMenu.SetActive(false);
    }

    public void GoToSettingsMenu()
    {
        Settings.LoadValues();
        MainMenu.SetActive(false);
        SettingsMenu.SetActive(true);
    }
}
