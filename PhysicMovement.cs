using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicMovement : MonoBehaviour
{
    public float force = 5f;
    public float rotationForce = 90f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Movement with asdf axis using physics
    void FixedUpdate()
    {
        rb.AddForce(Input.GetAxis("Horizontal") * Time.deltaTime * force, 0f, Input.GetAxis("Vertical") * Time.deltaTime * force);
        // Rotation with "Rotation" axis
        rb.AddTorque(0, Input.GetAxis("Rotation") * Time.deltaTime * rotationForce, 0);
    }
}
