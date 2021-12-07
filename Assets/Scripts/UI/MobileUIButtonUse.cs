using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileUIButtonUse : MonoBehaviour
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
    }

    public void UnPress()
    {
        //this.bindings.grabLedge.abord();
    }
}
