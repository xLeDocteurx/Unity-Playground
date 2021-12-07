using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileeUIJoystick : MonoBehaviour
{
    [SerializeField] private GameObject parent;
    [SerializeField] private VariableJoystick joystick;
    private Bindings bindings;

    // Start is called before the first frame update
    void Start()
    {
        this.bindings = this.parent.GetComponent<Bindings>();
    }

    // Update is called once per frame
    void Update()
    {
        this.bindings.movement.move(this.joystick.Direction);
    }
}
