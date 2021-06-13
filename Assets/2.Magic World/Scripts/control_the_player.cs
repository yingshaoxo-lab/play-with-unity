using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_the_player : MonoBehaviour
{
    private CharacterController characterController;
    public float movementSpeed, rotationSpeed, jumpSpeed, gravity;
    public Vector3 movementDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 inputMovement = transform.forward * movementSpeed * Input.GetAxisRaw("Vertical");
        characterController.Move(inputMovement * Time.deltaTime);

        transform.Rotate(Vector3.up * Input.GetAxisRaw("Horizontal") * rotationSpeed);

        if (Input.GetKeyDown(KeyCode.Space)) {// && characterController.isGrounded) {
            movementDirection.y += jumpSpeed;
            Debug.Log("jumped");
        }
        movementDirection.y -= gravity * Time.deltaTime;
        characterController.Move(movementDirection* Time.deltaTime);
    }
}
