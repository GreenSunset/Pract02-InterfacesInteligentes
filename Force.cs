using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    public GameObject typeAContainer;
    public float force = 10f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Rigidbody[] objects = typeAContainer.GetComponentsInChildren<Rigidbody>();
            foreach (Rigidbody rb in objects)
            {
                Vector3 direction = rb.transform.position - transform.position;
                float distance = direction.magnitude;
                rb.AddForce(direction.normalized * force / distance);
            }
        }
    }
}
