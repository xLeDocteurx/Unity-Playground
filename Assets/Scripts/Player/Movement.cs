using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{

    [Space]
    [SerializeField] private Camera cam;
    [SerializeField] private Animator anim;
    [SerializeField] private CharacterController controller;
    [SerializeField] private IsGrounded grounded;
    [Space]
    [SerializeField] private float walkSpeed = 3f;
    [SerializeField] private float runSpeed = 6f;
    [SerializeField] private float walkingTurnSmoothTime = 0.1f;
    [SerializeField] private float runningTurnSmoothTime = 0.05f;
    [Space]
    [SerializeField] private Vector2 inputVector = Vector2.zero;
    [SerializeField] private float turnSmoothVelocity;


    void Start()
    {
    }

    void Update()
    {
        if (this.controller.enabled && (this.anim.GetBool("isWalking") || this.anim.GetBool("isRunning")))
        {
            this.updateMovement();
        }
    }

    void FixedUpdate()
    {
    }

    private void updateMovement()
    {
        Vector3 direction = new Vector3(0, 0, 0);
        float turnSmoothTime = this.anim.GetBool("isRunning") ? this.runningTurnSmoothTime : this.walkingTurnSmoothTime;
        float playerSpeed = this.anim.GetBool("isRunning") ? this.runSpeed : this.walkSpeed;
        if (this.inputVector.x != 0 || this.inputVector.y != 0)
        {
            float targetAngle = Mathf.Atan2(this.inputVector.x, this.inputVector.y) * Mathf.Rad2Deg + cam.transform.eulerAngles.y;
            float rotation = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref this.turnSmoothVelocity, turnSmoothTime);

            direction += Quaternion.Euler(0f, rotation, 0f) * Vector3.forward * playerSpeed;
            this.transform.rotation = Quaternion.Euler(0f, rotation, 0f);
        }
        this.controller.Move(direction * Time.deltaTime);

        //// handle blocking colisions
        //if (this.inputVector.x == 0 && this.inputVector.y == 0)
        //{
        //    this.anim.SetBool("isWalking", false);
        //}
        //else
        //{
        //    this.anim.SetBool("isWalking", true);
        //}
    }

    public void move(Vector2 vector)
    {
        bool condition = vector.x > 0 || vector.y > 0;
        if (condition && this.controller.enabled)
        {
            this.anim.SetBool("isWalking", true);
        }
        else if (!condition)
        {
            this.anim.SetBool("isWalking", false);
        }
        this.inputVector = vector;
    }
    public void move(InputAction.CallbackContext context)
    {
        if (context.started && this.controller.enabled)
        {
            this.anim.SetBool("isWalking", true);
        }
        else if (context.performed)
        {
        }
        else if (context.canceled)
        {
            this.anim.SetBool("isWalking", false);
        }
        this.inputVector = context.ReadValue<Vector2>();
    }

    public void run(bool value)
    {
            this.anim.SetBool("isRunning", value);
    }
    public void run(InputAction.CallbackContext context)
    {
        if (context.started && this.controller.enabled)
        {
            this.anim.SetBool("isRunning", true);
        }
        else if (context.performed)
        {
        }
        else if (context.canceled)
        {
            this.anim.SetBool("isRunning", false);
        }
    }

    public void callCat()
    {
        this.anim.SetTrigger("callCat");
        this.anim.ResetTrigger("callCat");
    }
    public void callCat(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if (this.controller.enabled && this.grounded.isGrounded)
            {
                this.anim.SetTrigger("callCat");
                this.anim.ResetTrigger("callCat");
            }
        }
        else if (context.performed)
        {
        }
        else if (context.canceled)
        {
        }
    }
}
