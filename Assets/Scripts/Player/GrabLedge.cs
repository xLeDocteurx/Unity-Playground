using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class GrabLedge : MonoBehaviour
{

    [Space]
    [SerializeField] private Animator anim;
    [SerializeField] private CharacterController controller;
    [SerializeField] private IsGrounded grounded;
    [SerializeField] private Jump jump;
    private Subscription groundedSubscription;
    [Space]
    [SerializeField] private bool canGrabLedge = false;
    [SerializeField] private bool isAbording = false;
    [SerializeField] private PlayerLedgeChecker grabableLedge;

    void Start()
    {
        this.groundedSubscription = this.grounded.subscribe((value) =>
        {
            if (value == IsGroundedStates.land)
            {
                this.anim.ResetTrigger("abord");
                this.isAbording = false;
            }
        });
    }

    void Update()
    {
        if (!this.grounded.isGrounded && this.canGrabLedge && !this.grounded.isHanging && !this.isAbording)
        {
            //this.anim.ResetTrigger("jumpEnd");
            this.grabLedge();
        }
    }

    public void climb()
    {
        if (!this.grounded.isGrounded && this.grounded.isHanging)
        {
            this.anim.ResetTrigger("grabLedge");
            this.anim.SetTrigger("climb");
        }
    }
    public void climb(InputAction.CallbackContext context)
    {
        if (!this.grounded.isGrounded && this.grounded.isHanging)
        {
            if (context.started)
            {
                this.anim.ResetTrigger("grabLedge");
                this.anim.SetTrigger("climb");
            }
            else if (context.performed)
            {
            }
            else if (context.canceled)
            {
            }
        }
    }

    private void grabLedge()
    {
        Debug.Log("grabLedge");
        this.jump.resetVelocity();
        this.grounded.isHanging = true;
        this.anim.ResetTrigger("jumpStart");
        this.anim.SetTrigger("grabLedge");
        this.controller.enabled = false;
        if (!!this.grabableLedge)
        {
            this.transform.rotation = this.grabableLedge.startPosition.transform.rotation;
            //this.transform.position = this.grabableLedge.startPosition.transform.position;
            this.transform.position = new Vector3(this.grabableLedge.startPosition.transform.position.x, this.grabableLedge.startPosition.transform.position.y, this.transform.position.z);
        }
    }

    public void afterClimb()
    {
        // ???
        this.jump.resetVelocity();

        this.anim.ResetTrigger("climb");
        this.controller.enabled = true;
        if (!!this.grabableLedge)
        {
            this.transform.rotation = this.grabableLedge.endPosition.transform.rotation;
            //this.transform.position = this.grabableLedge.endPosition.transform.position;
            this.transform.position = new Vector3(this.grabableLedge.endPosition.transform.position.x, this.grabableLedge.endPosition.transform.position.y, this.grabableLedge.startPosition.transform.position.z);
        }
        this.grounded.isHanging = false;
        //this.grabableLedge = null;
        this.setCanGrabLedge(null, false);
    }

    public void abord()
    {
        if(this.grounded.isHanging)
        {
            //this.isAbording = false;
            this.isAbording = true;

            this.controller.enabled = true;
            this.anim.ResetTrigger("grabLedge");
            this.anim.SetTrigger("abord");
            this.grounded.isHanging = false;
            //this.grabableLedge = null;
            this.setCanGrabLedge(null, false);
        }
    }

    public void setCanGrabLedge(PlayerLedgeChecker grabableLedge, bool value)
    {
        if (!this.isAbording)
        {
            //if (!value && this.grabableLedge != grabableLedge)
            //{
            //    return;
            //}
            this.canGrabLedge = value;
            this.grabableLedge = grabableLedge;
        }
    }
}
