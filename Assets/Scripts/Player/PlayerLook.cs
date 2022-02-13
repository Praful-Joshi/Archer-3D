using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    //declaring components;
    public Transform shoulderObject;

    //declaring variables
    public float mouseSensitivity = 100f;
    public static float mouseX, mouseY;
    private float xRotation = 0f, yRotation = 0f;
    private Quaternion originalRotation;

    private void Start()
    {
        originalRotation = shoulderObject.rotation;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if(PlayerInput.aiming)
        {
            getMouseInput();
            rotateCamera();
            rotatePlayer();
        }
        else
        {
            shoulderObject.rotation = originalRotation;
        }
    }

    private void rotatePlayer()
    {
        this.transform.rotation = Quaternion.Euler(0, yRotation, 0);
    }

    private void rotateCamera()
    {
        shoulderObject.rotation = Quaternion.Euler(xRotation, yRotation, 0);
    }

    private void getMouseInput()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        xRotation -= mouseY;
        yRotation += mouseX;

        xRotation = Mathf.Clamp(xRotation, -20f, 20f);
        yRotation = Mathf.Clamp(yRotation, -20f, 20f);
    }
}
