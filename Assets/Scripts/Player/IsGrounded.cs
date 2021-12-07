using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class IsGrounded : MonoBehaviour
{
    [Space]
    [SerializeField] private Animator anim;
    [SerializeField] private CharacterController controller;
    [Space]
    [SerializeField] public bool isGrounded = false;
    [SerializeField] public bool isHanging = false;
    [SerializeField] private List<Action<IsGroundedStates>> _callbacks = new List<Action<IsGroundedStates>>();

    //void Start()
    //{
    //}

    void Update()
    {
        this.updateGrounded();
    }

    void FixedUpdate()
    {
    }

    private void updateGrounded()
    {
        if(this.controller.enabled)
        {
            bool grounded = (controller.collisionFlags & CollisionFlags.CollidedBelow) != 0;
            if (!this.isGrounded && grounded)
            {
                this.anim.SetBool("isInTheAir", false);
                this._callbacks.ForEach((callback) =>
                {
                    //this.anim.ResetTrigger("jumpEnd");
                    this.anim.ResetTrigger("abord");
                    this.anim.SetTrigger("jumpEnd");
                    callback(IsGroundedStates.land);
                });
            }
            else if (this.isGrounded && !grounded)
            {
                this.anim.SetBool("isInTheAir", true);
                this._callbacks.ForEach((callback) =>
                {
                    callback(IsGroundedStates.jump);
                });
            }
            this.isGrounded = grounded;
        }
    }

    public Subscription subscribe(Action<IsGroundedStates> callback)
    {
        this._callbacks.Add(callback);
        return new Subscription(() => { this._callbacks.Remove(callback); });
    }
}

public enum IsGroundedStates
{
    jump,
    land
}

public class Subscription
{
    private Action _callback;
    public Subscription(Action callback)
    {
        this._callback = callback;
    }
    public void unsubscribe()
    {
        this._callback();
    }
}