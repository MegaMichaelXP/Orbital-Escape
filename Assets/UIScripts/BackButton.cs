using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    MenuController MenuCont;
    Button MenuButton;
    GameObject MainMenu;
    GameObject[] SecondaryMenus;
    // Start is called before the first frame update
    void Awake()
    {
        MainMenu = GameObject.FindWithTag("Menu");
        SecondaryMenus = GameObject.FindGameObjectsWithTag("SecondaryMenu");
        MenuButton = gameObject.GetComponent<Button>();
        MenuButton.onClick.AddListener(BackToMain);
    }

    void BackToMain()
    {
        for (int i = 0; i < SecondaryMenus.Length; i++)
        {
            SecondaryMenus[i].SetActive(false);
        }
        MainMenu.SetActive(true);
    }
}
