using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefaultsButton : MonoBehaviour
{
    Button MenuButton;
    SettingsController Settings;
    // Start is called before the first frame update
    void Awake()
    {
        MenuButton = gameObject.GetComponent<Button>();
        MenuButton.onClick.AddListener(Defaults);
        Settings = GameObject.Find("SettingsMenu").GetComponent<SettingsController>();
    }

    void Defaults()
    {
        Settings.DefaultValues();
    }
}
