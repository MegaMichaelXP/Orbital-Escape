using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float XSensitivity;
    [SerializeField] float YSensitivity;

    Camera PlayerCamera;

    float MouseX;
    float MouseY;
    float Multiplier = 0.1f;
    float XRot;
    float YRot;
    bool Menu = false;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCamera = GetComponentInChildren<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        GetPlayerInput();
        PlayerCamera.transform.localRotation = Quaternion.Euler(XRot, 0, 0);
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
        MouseX = Input.GetAxisRaw("Mouse X");
        MouseY = Input.GetAxisRaw("Mouse Y");
        YRot += MouseX * XSensitivity * Multiplier;
        XRot -= MouseY * YSensitivity * Multiplier;
        XRot = Mathf.Clamp(XRot, -90f, 90f);
    }
}
