using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SensitivityFactorSlider : MonoBehaviour
{
    DataKeeper DataStore;

    Slider MenuSlider;
    TMPro.TMP_Text SensitivityFactorText;
    float SensitivityFactor;
    
    void Awake()
    {
        MenuSlider = gameObject.GetComponent<Slider>();
        MenuSlider.onValueChanged.AddListener(delegate { ValueUpdate(); });
        DataStore = GameObject.Find("DataKeeper").GetComponent<DataKeeper>();
        SensitivityFactor = DataStore.GetSensitivityFactor();
        SensitivityFactorText = GameObject.Find("SensitivityFactor").GetComponent<TMP_Text>();
    }

    void ValueUpdate()
    {
        SensitivityFactor = (float)MenuSlider.value;
        SensitivityFactorText.SetText(System.Math.Round(SensitivityFactor, 2).ToString() + "x");
        DataStore.UpdateSensitivityFactor(SensitivityFactor);
    }

    public void LoadValue()
    {
        MenuSlider.value = DataStore.GetSensitivityFactor();
        SensitivityFactor = (float)MenuSlider.value;
        SensitivityFactorText.SetText(System.Math.Round(SensitivityFactor, 2).ToString() + "x");
    }

    public void DefaultValue()
    {
        MenuSlider.value = DataStore.GetDefaultSensitivityFactor();
        SensitivityFactor = (float)MenuSlider.value;
        SensitivityFactorText.SetText(System.Math.Round(SensitivityFactor, 2).ToString() + "x");
    }
}
