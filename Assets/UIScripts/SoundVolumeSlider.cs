using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SoundVolumeSlider : MonoBehaviour
{
    DataKeeper DataStore;

    Slider MenuSlider;
    TMPro.TMP_Text SoundVolumeText;
    float SoundVolume;
    
    void Awake()
    {
        MenuSlider = gameObject.GetComponent<Slider>();
        MenuSlider.onValueChanged.AddListener(delegate { ValueUpdate(); });
        DataStore = GameObject.Find("DataKeeper").GetComponent<DataKeeper>();
        SoundVolume = DataStore.GetSoundVolume();
        SoundVolumeText = GameObject.Find("SoundVolume").GetComponent<TMP_Text>();
    }

    void ValueUpdate()
    {
        SoundVolume = (float)MenuSlider.value;
        SoundVolumeText.SetText(System.Math.Round(SoundVolume * 100, 0).ToString() + "%");
        DataStore.UpdateSoundVolume(SoundVolume);
    }

    public void LoadValue()
    {
        MenuSlider.value = DataStore.GetSoundVolume();
        SoundVolume = (float)MenuSlider.value;
        SoundVolumeText.SetText(System.Math.Round(SoundVolume * 100, 0).ToString() + "%");
    }

    public void DefaultValue()
    {
        MenuSlider.value = DataStore.GetDefaultSoundVolume();
        SoundVolume = (float)MenuSlider.value;
        SoundVolumeText.SetText(System.Math.Round(SoundVolume * 100, 0).ToString() + "%");
    }
}
