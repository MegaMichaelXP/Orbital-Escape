using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    Button MenuButton;
    // Start is called before the first frame update
    void Start()
    {
        MenuButton = gameObject.GetComponent<Button>();
        MenuButton.onClick.AddListener(QuitGame);
    }

    void QuitGame()
    {
        Application.Quit();
    }
}
