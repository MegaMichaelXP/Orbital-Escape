using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Introduction : MonoBehaviour
{
    TextFade[] IntroText = new TextFade[5];

    float TimeStamp;
    int IntroStage = 0;

    // Start is called before the first frame update
    void Start()
    {
        IntroText[0] = GameObject.Find("IntroTextA").GetComponent<TextFade>();
        IntroText[1] = GameObject.Find("IntroTextB").GetComponent<TextFade>();
        IntroText[2] = GameObject.Find("IntroTextC").GetComponent<TextFade>();
        IntroText[3] = GameObject.Find("IntroTextD").GetComponent<TextFade>();
        IntroText[4] = GameObject.Find("IntroTextE").GetComponent<TextFade>();
        TimeStamp = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= TimeStamp + 1 && IntroStage == 0)
        {
            IntroText[IntroStage].FadeInText();
            IntroStage++;
            TimeStamp = Time.time;
        }
        else if (Time.time >= TimeStamp + 2 && IntroStage < 3)
        {
            IntroText[IntroStage].FadeInText();
            IntroStage++;
            TimeStamp = Time.time;
        }
        else if (Time.time >= TimeStamp + 3 && IntroStage < 5)
        {
            IntroText[IntroStage].FadeInText();
            IntroStage++;
            TimeStamp = Time.time;
        }
        else if (Time.time >= TimeStamp + 5 && IntroStage == 5)
        {
            SceneManager.LoadScene("Game");
        }
    }
}
