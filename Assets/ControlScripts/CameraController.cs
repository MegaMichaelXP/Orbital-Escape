using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float XSensitivity;
    [SerializeField] float YSensitivity;

    Camera PlayerCamera;
    Light Flashlight;

    float MouseX;
    float MouseY;
    float Multiplier = 0.1f;
    float XRot;
    float YRot;
    bool Menu = false;
    bool UsingFlashlight = true;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCamera = GetComponentInChildren<Camera>();
        Flashlight = GetComponentInChildren<Light>();
        Cursor.lockState = CursorLockMode.Locked;
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
                Cursor.lockState = CursorLockMode.None;
                Menu = true;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Menu = false;
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
            YRot += MouseX * XSensitivity * Multiplier;
            XRot -= MouseY * YSensitivity * Multiplier;
            XRot = Mathf.Clamp(XRot, -90f, 90f);
        }
    }
}
