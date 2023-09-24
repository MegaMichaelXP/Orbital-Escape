using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{
    MenuController MenuCont;

    SensitivityFactorSlider SFSlider;
    SoundVolumeSlider SVSlider;
    MusicVolumeSlider MVSlider;

    void Awake()
    {
        SFSlider = GameObject.Find("SensitivityFactorSlider").GetComponent<SensitivityFactorSlider>();
        SVSlider = GameObject.Find("SoundVolumeSlider").GetComponent<SoundVolumeSlider>();
        MVSlider = GameObject.Find("MusicVolumeSlider").GetComponent<MusicVolumeSlider>();
    }

    void Start()
    {
        gameObject.SetActive(false);
    }

    public void LoadValues()
    {
        SFSlider.LoadValue();
        SVSlider.LoadValue();
        MVSlider.LoadValue();
    }

    public void DefaultValues()
    {
        SFSlider.DefaultValue();
        SVSlider.DefaultValue();
        MVSlider.DefaultValue();
    }
}
