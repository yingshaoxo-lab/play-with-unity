using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_the_camera_around : MonoBehaviour
{
    // Start is called before the first frame update
    public float moving_speed = 100.0f;

    public float speedH = 2.0f;
    public float speedV = 2.0f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * moving_speed * forwardInput);

        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * moving_speed * horizontalInput);
    }

    void OnGUI()
    {
        Event e = Event.current;
        if (e.alt)
        {
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");
            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
    }
}