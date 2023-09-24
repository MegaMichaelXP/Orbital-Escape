using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DataKeeper : MonoBehaviour
{
    public static DataKeeper Instance;

    const float DefaultSensitivityFactor = 1.0f;
    const float DefaultSoundVolume = 0.7f;
    const float DefaultMusicVolume = 0.7f;

    float SensitivityFactor = 1.0f;
    float SoundVolume = 0.7f;
    float MusicVolume = 0.7f;

    TMPro.TMP_Text SensitivityFactorText;

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        
    }

    public float GetSensitivityFactor()
    {
        return SensitivityFactor;
    }

    public float GetSoundVolume()
    {
        return SoundVolume;
    }

    public float GetMusicVolume()
    {
        return MusicVolume;
    }

    public float GetDefaultSensitivityFactor()
    {
        SensitivityFactor = DefaultSensitivityFactor;
        return DefaultSensitivityFactor;
    }

    public float GetDefaultSoundVolume()
    {
        SoundVolume = DefaultSoundVolume;
        return DefaultSoundVolume;
    }

    public float GetDefaultMusicVolume()
    {
        MusicVolume = DefaultMusicVolume;
        return DefaultMusicVolume;
    }

    public void UpdateSensitivityFactor(float NewValue)
    {
        SensitivityFactor = NewValue;
    }

    public void UpdateSoundVolume(float NewValue)
    {
        SoundVolume = NewValue;
    }

    public void UpdateMusicVolume(float NewValue)
    {
        MusicVolume = NewValue;
    }
}
