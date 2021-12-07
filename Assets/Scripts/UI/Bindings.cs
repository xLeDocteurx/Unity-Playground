using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bindings : MonoBehaviour
{

    [SerializeField] private GameObject player;
    public IsGrounded isGrounded;
    public Movement movement;
    public Jump jump;
    public GrabLedge grabLedge;



    // Start is called before the first frame update
    void Start()
    {
        this.isGrounded = this.player.GetComponent<IsGrounded>();
        this.movement = this.player.GetComponent<Movement>();
        this.jump = this.player.GetComponent<Jump>();
        this.grabLedge = this.player.GetComponent<GrabLedge>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//public enum Actions {
//    move,
//    jump,
//    grabLedge
//}