using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target; // The target to follow
    [SerializeField] float smoothTime = 0.3f; // The time it takes for the camera to catch up with the target
    [SerializeField] Vector3 minPos, maxPos; // The minimum and maximum positions the camera is allowed to be

    private Vector3 velocity;

    void Update()
    {
        // Calculate the desired position for the camera
        Vector3 desiredPosition = target.position;
        desiredPosition.z = -10; // Set the z position of the camera to keep it in the background

        // Smoothly move the camera towards the desired position
        transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothTime);

        // Clamp the camera position to the minimum and maximum values
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, minPos.x, maxPos.x),
            Mathf.Clamp(transform.position.y, minPos.y, maxPos.y),
            transform.position.z
        );
    }
}