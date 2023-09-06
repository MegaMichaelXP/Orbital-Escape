using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    Button MenuButton;
    // Start is called before the first frame update
    void Start()
    {
        MenuButton = gameObject.GetComponent<Button>();
        MenuButton.onClick.AddListener(PlayGame);
    }

    void PlayGame()
    {
        SceneManager.LoadScene("Intro");
    }
}
