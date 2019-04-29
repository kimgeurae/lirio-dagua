using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
    public Transform target;
    public float distance = 5.0f;
    public float xSpeed = 120.0f;
    //default for yspeed is 120.0f;
    public float ySpeed = 240.0f;

    public float yMinLimit = -80f;
    public float yMaxLimit = 80f;

    public float distanceMin = .5f;
    public float distanceMax = 15f;

    public float deadzone = 0.02f;

    private Rigidbody rigidbody;

    float x = 0.0f;
    float y = 0.0f;

    // Use this for initialization
    void Start()
    {
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;

        // Make the rigid body not change rotation
        if (target.GetComponent<Rigidbody>() != null)
        {
            rigidbody = target.GetComponent<Rigidbody>();
            rigidbody.freezeRotation = true;
        }
    }

    private void Update()
    {
        //Debug.Log("RightAnalogX = " + Input.GetAxis("RightAnalogX"));
        //Debug.Log("RightAnalogY = " + Input.GetAxis("RightAnalogY"));   
    }

    void LateUpdate()
    {
        if (target)
        {
            //x += Input.GetAxis("Mouse X") * xSpeed * distance * 0.02f;
            //y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;

            if (Input.GetAxis("RightAnalogX") > deadzone || Input.GetAxis("RightAnalogX") < -deadzone)
            {
                x += Input.GetAxis("RightAnalogX") * xSpeed * distance * 0.02f;
            }
            if (Input.GetAxis("RightAnalogY") > deadzone || Input.GetAxis("RightAnalogY") < -deadzone)
            {
                y -= Input.GetAxis("RightAnalogY") * ySpeed * 0.02f;
            }

            x += Input.GetAxis("Mouse X") * xSpeed * distance * 0.02f;
            y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;

            y = ClampAngle(y, yMinLimit, yMaxLimit);

            Quaternion rotation = Quaternion.Euler(y, x, 0);

            distance = Mathf.Clamp(distance - Input.GetAxis("Mouse ScrollWheel") * 5, distanceMin, distanceMax);
            /*RaycastHit hit;
            if (Physics.Linecast(target.position, transform.position, out hit))
            {
                distance -= hit.distance;
            }*/
            Vector3 negDistance = new Vector3(0.0f, 0.0f, -distance);
            Vector3 position = rotation * negDistance + target.position;
            transform.rotation = rotation;
            transform.position = position;
        }
    }

    public static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360F)
            angle += 360F;
        if (angle > 360F)
            angle -= 360F;
        return Mathf.Clamp(angle, min, max);
    }
}
