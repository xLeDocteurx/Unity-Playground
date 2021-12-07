using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInterractionsChecker : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Interraction Checker"))
        {
            other.GetComponentInParent<Interract>().setCanInterract(this.gameObject, true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Interraction Checker"))
        {
            other.GetComponentInParent<Interract>().setCanInterract(this.gameObject, false);
        }
    }
}
