using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_the_player : MonoBehaviour
{
    private CharacterController characterController;
    public float movementSpeed, rotationSpeed, jumpSpeed, gravity;
    public Vector3 movementDirection = Vector3.zero;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        var vertical_input =  Input.GetAxisRaw("Vertical");
        var horizontal_input = Input.GetAxisRaw("Horizontal");

        if (vertical_input > 0 || horizontal_input > 0) {
            animator.Play("walking");
        } else {
            animator.Play("standing");
        }

        // code that handles the forward moving
        Vector3 inputMovement = transform.forward * movementSpeed * vertical_input;
        characterController.Move(inputMovement * Time.deltaTime);

        // code that handles the rotation
        transform.Rotate(Vector3.up * horizontal_input * rotationSpeed);

        // code that handles the jump
        if (Input.GetKeyDown(KeyCode.Space)) {// && characterController.isGrounded) {
            movementDirection.y = jumpSpeed;
        }
        movementDirection.y -= gravity * Time.deltaTime;
        characterController.Move(movementDirection* Time.deltaTime);
    }
}
