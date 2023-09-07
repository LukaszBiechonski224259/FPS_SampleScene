using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("References")]
    public Transform orientation;

    [Header("Config")] 
    private Vector3 rotation;
    private float xRotation, yRotation;
    public float xSensitivity, ySensitivity;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        CameraRotation();
    }
    
    private void CameraRotation()
    {
        float xMouse = Input.GetAxis("Mouse X") * Time.deltaTime * xSensitivity;
        float yMouse = Input.GetAxis("Mouse Y") * Time.deltaTime * ySensitivity;

        yRotation += xMouse;
        xRotation -= yMouse;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        
        //
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
