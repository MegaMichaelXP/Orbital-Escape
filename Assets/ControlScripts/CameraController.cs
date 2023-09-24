using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float XSensitivity;
    [SerializeField] float YSensitivity;

    Camera PlayerCamera;
    Light Flashlight;
    DataKeeper DataStore;

    GameObject PauseMenu;
    GameObject SettingsMenu;
    GameObject Pointer;

    float MouseX;
    float MouseY;
    float SensitivityFactor;
    float Multiplier = 0.1f;
    float XRot;
    float YRot;
    bool Menu = false;
    bool UsingFlashlight = true;
    // Start is called before the first frame update
    void Awake()
    {
        PlayerCamera = GetComponentInChildren<Camera>();
        Flashlight = GetComponentInChildren<Light>();
        PauseMenu = GameObject.Find("PauseMenu");
        SettingsMenu = GameObject.Find("SettingsMenu");
        Pointer = GameObject.Find("Pointer");
        DataStore = GameObject.Find("DataKeeper").GetComponent<DataKeeper>();
        SensitivityFactor = DataStore.GetSensitivityFactor();
    }

    void Start()
    {
        PauseMenu.SetActive(false);
        Pointer.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        GetPlayerInput();
        PlayerCamera.transform.localRotation = Quaternion.Euler(XRot, 0, 0);
        Flashlight.transform.localRotation = Quaternion.Euler(XRot, 0, 0);
        transform.rotation = Quaternion.Euler(0, YRot, 0);
    }

    void GetPlayerInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!Menu)
            {
                PauseGame();
            }
            else
            {
                UnpauseGame();
            }
        }
        if (!Menu)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (!UsingFlashlight)
                {
                    Flashlight.intensity = 0.8f;
                    UsingFlashlight = true;
                }
                else
                {
                    Flashlight.intensity = 0f;
                    UsingFlashlight = false;
                }
            }
            MouseX = Input.GetAxisRaw("Mouse X");
            MouseY = Input.GetAxisRaw("Mouse Y");
            YRot += MouseX * XSensitivity * Multiplier * SensitivityFactor;
            XRot -= MouseY * YSensitivity * Multiplier * SensitivityFactor;
            XRot = Mathf.Clamp(XRot, -90f, 90f);
        }
    }

    public void PauseGame()
    {
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
        Pointer.SetActive(false);
        PauseMenu.SetActive(true);
        Menu = true;
    }

    public void UnpauseGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        SensitivityFactor = DataStore.GetSensitivityFactor();
        Time.timeScale = 1;
        Pointer.SetActive(true);
        PauseMenu.SetActive(false);
        SettingsMenu.SetActive(false);
        Menu = false;
    }
}
