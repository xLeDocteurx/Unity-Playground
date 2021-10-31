using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Knight : MonoBehaviour
{

    public Animator anim;
    public CharacterController controller;
    [Space]
    public Camera cam;
    [Space]
    public float playerWalkSpeed = 3f;
    public float playerRunSpeed = 6f;
    public float walkingTurnSmoothTime = 0.1f;
    public float runningTurnSmoothTime = 0.05f;
    [Space]
    public Vector2 vector;
    float turnSmoothVelocity;
    [Space]
    public Vector3 test;

    void Start()
    {
        this.vector = new Vector2(0,0);
        //this.anim = GetComponent<Animator>();
        //anim.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        this.updateMovement();
    }

    private void updateMovement()
    {
        if (this.controller.velocity.x == 0 && this.controller.velocity.z == 0)
        {
            this.anim.SetBool("isMoving", false);
        }
        else
        {
            this.anim.SetBool("isMoving", true);
        }

        if (this.vector.x != 0 || this.vector.y != 0)
        {
            float turnSmoothTime = this.anim.GetBool("isRunning") ? this.runningTurnSmoothTime : this.walkingTurnSmoothTime;
            float playerSpeed = this.anim.GetBool("isRunning") ? this.playerRunSpeed : this.playerWalkSpeed;

            float targetAngle = Mathf.Atan2(this.vector.x, this.vector.y) * Mathf.Rad2Deg + cam.transform.eulerAngles.y;
            float rotation = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref this.turnSmoothVelocity, turnSmoothTime);
            Vector3 direction = Quaternion.Euler(0f, rotation, 0f) * Vector3.forward;

            this.transform.rotation = Quaternion.Euler(0f, rotation, 0f);
            this.controller.Move(direction * Time.deltaTime * playerSpeed);
        }
    }

    public void move(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            this.anim.SetBool("isMoving", true);
        }
        else if (context.performed)
        {
        }
        else if (context.canceled)
        {
            this.anim.SetBool("isMoving", false);
        }
        this.vector = context.ReadValue<Vector2>();
    }

    public void run(InputAction.CallbackContext context)
    {
        if (context.started)
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

    public void jump(InputAction.CallbackContext context)
    {

        if (context.started) {
            this.anim.SetTrigger("jump");
        } else if (context.performed) {
        } else if (context.canceled) {
        }
    }

    public void callCat(InputAction.CallbackContext context)
    {

        if (context.started) {
            this.anim.SetTrigger("callCat");
        } else if (context.performed) {
        } else if (context.canceled) {
        }
    }

}
