using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_the_player : MonoBehaviour
{
    private CharacterController characterController;
    public float movementSpeed, rotationSpeed, jumpSpeed, gravity;
    public float runningSpeed, runningRotationSpeed;
    public Vector3 movementDirection = Vector3.zero;
    Animator animator;
    public GameObject[] cameraList;

    public GameObject magicPortal;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool is_shift_in_pressing = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);

        var vertical_input = Input.GetAxisRaw("Vertical");
        var horizontal_input = Input.GetAxisRaw("Horizontal");

        if (Mathf.Abs(vertical_input) > 0)
        {
            if (is_shift_in_pressing)
            {
                cameraList[0].gameObject.SetActive(true);
                cameraList[1].gameObject.SetActive(false);
                animator.Play("running");
            }
            else
            {
                cameraList[0].gameObject.SetActive(false);
                cameraList[1].gameObject.SetActive(true);
                animator.Play("walking");
            }
        }
        else
        {
            cameraList[0].gameObject.SetActive(false);
            cameraList[1].gameObject.SetActive(true);
            animator.Play("standing");
        }

        // code that handles the forward moving
        if (is_shift_in_pressing)
        {
            Vector3 inputMovement = transform.forward * runningSpeed * vertical_input;
            characterController.Move(inputMovement * Time.deltaTime);
        }
        else
        {
            Vector3 inputMovement = transform.forward * movementSpeed * vertical_input;
            characterController.Move(inputMovement * Time.deltaTime);
        }

        // code that handles the rotation
        if (is_shift_in_pressing)
        {
            transform.Rotate(Vector3.up * horizontal_input * runningRotationSpeed);
        }
        else
        {
            transform.Rotate(Vector3.up * horizontal_input * rotationSpeed);
        }

        // code that handles the jump
        if (Input.GetKeyDown(KeyCode.Space))
        {// && characterController.isGrounded) {
            movementDirection.y = jumpSpeed;
        }

        movementDirection.y -= gravity * Time.deltaTime;
        characterController.Move(movementDirection * Time.deltaTime);

        //attack
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(magicPortal, transform.position + new Vector3(0, 1, 0), transform.rotation);
        }
    }
}
