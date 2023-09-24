using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MusicVolumeSlider : MonoBehaviour
{
    DataKeeper DataStore;

    Slider MenuSlider;
    TMPro.TMP_Text MusicVolumeText;
    float MusicVolume;
    // Start is called before the first frame update
    void Awake()
    {
        MenuSlider = gameObject.GetComponent<Slider>();
        MenuSlider.onValueChanged.AddListener(delegate { ValueUpdate(); });
        DataStore = GameObject.Find("DataKeeper").GetComponent<DataKeeper>();
        MusicVolume = DataStore.GetSoundVolume();
        MusicVolumeText = GameObject.Find("MusicVolume").GetComponent<TMP_Text>();
    }

    void ValueUpdate()
    {
        MusicVolume = (float)MenuSlider.value;
        MusicVolumeText.SetText(System.Math.Round(MusicVolume * 100, 0).ToString() + "%");
        DataStore.UpdateMusicVolume(MusicVolume);
    }

    public void LoadValue()
    {
        MenuSlider.value = DataStore.GetMusicVolume();
        MusicVolume = (float)MenuSlider.value;
        MusicVolumeText.SetText(System.Math.Round(MusicVolume * 100, 0).ToString() + "%");
    }

    public void DefaultValue()
    {
        MenuSlider.value = DataStore.GetDefaultMusicVolume();
        MusicVolume = (float)MenuSlider.value;
        MusicVolumeText.SetText(System.Math.Round(MusicVolume * 100, 0).ToString() + "%");
    }
}
