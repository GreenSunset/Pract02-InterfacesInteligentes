using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicMovement : MonoBehaviour
{
    public float force = 20f;
    public float rotationForce = 90f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Movement with asdf axis using physics
    void FixedUpdate()
    {
        rb.AddForce(Input.GetAxis("AltHorizontal") * Time.fixedDeltaTime * force, 0f, Input.GetAxis("AltVertical") * Time.fixedDeltaTime * force);
        // Rotation with "Rotation" axis
        rb.AddTorque(0, Input.GetAxis("Rotation") * Time.fixedDeltaTime * rotationForce, 0);
    }
}
