using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileUIButtonCallCatAbord : MonoBehaviour
{
    [SerializeField] private GameObject parent;
    private Bindings bindings;

    // Start is called before the first frame update
    void Start()
    {
        this.bindings = this.parent.GetComponent<Bindings>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Press()
    {
        this.bindings.movement.callCat();
        this.bindings.grabLedge.abord();
    }

    public void UnPress()
    {
    }
}
