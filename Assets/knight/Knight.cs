using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Knight : MonoBehaviour
{

    public Animator anim;
    public CharacterController controller;
    [Space]
    public float playerWalkSpeed = 3f;
    public float playerRunSpeed = 6f;
    [Space]
    public Vector2 vector;
    float turnSmoothVelocity;
    public float turnSmoothTime = 0.1f;

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
        this.updateRotation();
    }

    private void updateMovement()
    {
        this.controller.Move(new Vector3(this.vector.x, 0, this.vector.y) * Time.deltaTime * this.playerWalkSpeed);
    }

    private void updateRotation()
    {
        if (this.vector.x != 0 || this.vector.y != 0)
        {
            float targetAngle = Mathf.Atan2(this.vector.x, this.vector.y) * Mathf.Rad2Deg;
            float rotation = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref this.turnSmoothVelocity, this.turnSmoothTime);
            this.transform.rotation = Quaternion.Euler(0f, rotation, 0f);
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
            //this.anim.SetBool("isMoving", false);
        }
        else if (context.canceled)
        {
            this.anim.SetBool("isMoving", false);
        }
        this.vector = (context.ReadValueAsObject() as Vector2?).Value;
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
