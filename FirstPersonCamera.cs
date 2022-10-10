using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{

    public Transform player;

    public Vector3 offset = new Vector3(0f, 0f, 0f);

    public float cameraRotationSpeed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;

        if(Input.GetMouseButton(1))
        {
            float pitch = cameraRotationSpeed * Input.GetAxis("Mouse Y");
            float yaw = cameraRotationSpeed * Input.GetAxis("Mouse X");
            transform.Rotate(-pitch, yaw, 0);

            float z = transform.eulerAngles.z;
            transform.Rotate(0, 0, -z);
        }
    }
}
