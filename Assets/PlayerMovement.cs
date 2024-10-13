using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 100.0f;

    [SerializeField]
    private float rotationSpeed = 100.0f;

    public InputActionReference leftJoystick;
    public InputActionReference rightJoystick;

    private Transform player;

    private void Start()
    {
        player = Camera.main.transform.parent;
    }

    private void Update()
    {
        if (player == null) return;
        Vector2 input = leftJoystick.action.ReadValue<Vector2>();
        Vector3 moveDirection = new Vector3(input.x, 0, input.y);
        moveDirection = player.TransformDirection(moveDirection);
        player.transform.position += moveDirection * moveSpeed * Time.deltaTime;

        Vector2 rightInput = rightJoystick.action.ReadValue<Vector2>();
        float horizontalRotation = rightInput.x;
        player.Rotate(0, horizontalRotation * rotationSpeed * Time.deltaTime, 0);
    }
}
