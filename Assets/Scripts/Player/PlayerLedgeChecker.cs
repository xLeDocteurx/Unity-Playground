using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLedgeChecker : MonoBehaviour
{
    public GameObject startPosition;
    public GameObject endPosition;

    void Start()
    {
        
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ledge Checker"))
        {
            other.GetComponentInParent<GrabLedge>().setCanGrabLedge(this, true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ledge Checker"))
        {
            other.GetComponentInParent<GrabLedge>().setCanGrabLedge(this, false);
        }
    }
}
