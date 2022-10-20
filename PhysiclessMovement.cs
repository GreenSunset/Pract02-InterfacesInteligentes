using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysiclessMovement : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 90f;
    
    void Update()
    {
        // Transform es accesible sin necesidad de usar GetComponent
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0f, Input.GetAxis("Vertical") * Time.deltaTime * speed);
        transform.Rotate(0, Input.GetAxis("Rotation") * Time.deltaTime * rotationSpeed, 0);
    }
}
