using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextFade : MonoBehaviour
{
    TMP_Text IntroText;
    // Start is called before the first frame update
    void Start()
    {
        IntroText = gameObject.GetComponent<TMP_Text>();
        IntroText.color = new Color(1, 1, 0, 0);
    }

    public void FadeInText()
    {
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            IntroText.color = new Color(1, 1, 0, i);
            yield return null;
        }
    }

}
