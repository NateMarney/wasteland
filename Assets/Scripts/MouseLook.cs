using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Allows the camera to follow the Mouse. To be attached to the player object. May need to be extended to add controller support.
*/
public class MouseLook : MonoBehaviour
{

    public Transform playerBody;
    public Transform playerEyes;
    public float mouseSensitivity = 100f;
    public float maxCameraAngleDown = 60f;
    public float maxCameraAngleUp = 90f;

    private Vector2 cameraLookDirection;
    private float yRotation = 0.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        PositionCameraAtPlayerEyes();
        cameraLookDirection = GetMouseLookDirection();
        yRotation -= cameraLookDirection.y;
        yRotation = Mathf.Clamp(yRotation, -maxCameraAngleUp, maxCameraAngleDown);
        RotateCameraVertically(yRotation);
        RotatePlayerBody(cameraLookDirection.x);
    }

    Vector2 GetMouseLookDirection()
    {
        return new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")) * mouseSensitivity * Time.deltaTime;
    }

    void RotatePlayerBody(float mouseX)
    {
        playerBody.Rotate(Vector3.up * mouseX);
    }

    void PositionCameraAtPlayerEyes()
    {
        transform.position = playerEyes.position;
    }

    void RotateCameraVertically(float yRotation)
    {
        transform.localEulerAngles = new Vector3(yRotation, 0.0f, 0.0f);
    }


}
