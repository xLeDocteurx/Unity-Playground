using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{

    [Space]
    [SerializeField] private Animator anim;
    [SerializeField] private CharacterController controller;
    [SerializeField] private IsGrounded grounded;
    private Subscription groundedSubscription;
    [Space]
    [SerializeField] private float jumpHeight = 1f;
    [Space]
    [SerializeField] private Vector3 velocity = Vector3.zero;

    void Start()
    {
        this.groundedSubscription = this.grounded.subscribe((value) =>
        {
            if (value == IsGroundedStates.land)
                {
                //Debug.Log("jumpEnd");
                this.anim.ResetTrigger("jumpStart");
                this.anim.SetTrigger("jumpEnd");
            }
        });
    }

    void Update()
    {
        if (this.controller.enabled)
        {
            this.updateVelocity();
        }
    }

    void FixedUpdate()
    {
    }

    private void OnDestroy()
    {
        this.groundedSubscription.unsubscribe();
    }

    private void updateVelocity()
    {
        if (this.velocity.y > Physics.gravity.y)
        {
            this.velocity.y += Physics.gravity.y * Time.deltaTime;
        }

        this.controller.Move(this.velocity * Time.deltaTime);
    }

    public void jumpStart()
    {
        if (this.controller.enabled && this.grounded.isGrounded && !this.grounded.isHanging)
        {
                this.anim.ResetTrigger("jumpEnd");
                this.anim.SetTrigger("jumpStart");
        }
    }
    public void jumpStart(InputAction.CallbackContext context)
    {
        if (this.controller.enabled && this.grounded.isGrounded && !this.grounded.isHanging)
        {
            if (context.started)
            {
                this.anim.ResetTrigger("jumpEnd");
                this.anim.SetTrigger("jumpStart");
            }
            else if (context.performed)
            {
            }
            else if (context.canceled)
            {
            }
        }
        else
        {

        }
    }

    public void jump()
    {
        this.velocity.y += this.jumpHeight * 0.5f * (-Physics.gravity.y) - Physics.gravity.y;
    }

    public void resetVelocity()
    {
        this.velocity = new Vector3(0, 0, 0);
    }

}
