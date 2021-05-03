using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingACube : MonoBehaviour
{
    public float speed = 10.0f;
    public float turnSpeed = 2f;
    public float forwardInput;
    public float horizontalInput;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        if (forwardInput != 0) {
            var cube_list = FindObjectsOfType<MovingACube>();
            int index = Random.Range(0, cube_list.Length - 1);
            var cube = cube_list[index];

            cube.transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput != 0) {
            var cube_list = FindObjectsOfType<MovingACube>();
            int index = Random.Range(0, cube_list.Length - 1);
            var cube = cube_list[index];

            cube.transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        }
    }
}