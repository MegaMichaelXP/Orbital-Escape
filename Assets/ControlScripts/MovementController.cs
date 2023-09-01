using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    float HorizontalMovement;
    float VerticalMovement;
    float FloatingMovement;
    [SerializeField] float MoveSpeed;
    Vector3 HVMovement;
    Rigidbody PlayerBody;
    // Start is called before the first frame update
    void Start()
    {
        PlayerBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GetPlayerInput();
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void GetPlayerInput()
    {
        HorizontalMovement = Input.GetAxisRaw("Horizontal");
        VerticalMovement = Input.GetAxisRaw("Vertical");
        FloatingMovement = Input.GetAxisRaw("Floating");

        HVMovement = transform.forward * VerticalMovement + transform.right * HorizontalMovement;
    }

    void MovePlayer()
    {
        PlayerBody.AddForce(HVMovement * MoveSpeed, ForceMode.Acceleration);
        PlayerBody.AddForce(transform.up * FloatingMovement * MoveSpeed, ForceMode.Acceleration);
    }

}
