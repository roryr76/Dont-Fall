/*
 * Owen O' Dea
 * 
 * 
 * */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Look : MonoBehaviour
{

    //This sets the mouse sensitivity
    public float mouseSensitivity = 100.0f;
    //Gets the location of the playerbody
    public Transform playerBody;
    //sets the x rotation to 0 so so camera around like a human
    float xRotation = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Locks the cursor so u dont click off screen when looking around. 
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Moves the camera around the X and Y 
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Moves the camera and locks it in to give more relastic look.
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        //Moves the body with the camera. 
        playerBody.Rotate(Vector3.up * mouseX);

    }
}