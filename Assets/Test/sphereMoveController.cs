using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereMoveController : MonoBehaviour
{
    Rigidbody rigibody;

    private void Start()
    {
        rigibody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        InputSystem(KeyCode.W, new Vector3(-1, 0,0));
        InputSystem(KeyCode.A, new Vector3(0, 0, -1));
        InputSystem(KeyCode.S, new Vector3(1, 0, 0));
        InputSystem(KeyCode.D, new Vector3(0, 0, 1));
    }

    void InputSystem(KeyCode key, Vector3 vect3)
    {
        if(Input.GetKey(key))
        {
            rigibody.AddForce(vect3);
        }
    }

}
