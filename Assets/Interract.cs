using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interract : MonoBehaviour
{
    //[Space]
    //[SerializeField] private Animator anim;
    //[SerializeField] private CharacterController controller;
    //[SerializeField] private IsGrounded grounded;
    //[SerializeField] private Jump jump;
    private Subscription groundedSubscription;
    [Space]
    [SerializeField] private bool canInterract = false;
    [SerializeField] private bool isAbording = false;
    [SerializeField] private GameObject interractable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setCanInterract(GameObject interractable, bool value)
    {
        if (!this.isAbording)
        {
            //if(!value && this.interractable != interractable)
            //{
            //    return;
            //}
            this.canInterract = value;
            this.interractable = interractable;
        }
    }
}
