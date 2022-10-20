using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    public GameObject cylinderContainer;
    public float force = 10f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody[] objects = cylinderContainer.GetComponentsInChildren<Rigidbody>();
            foreach (Rigidbody rb in objects)
            {
                if (rb.gameObject.tag == "TypeA")
                {
                    Vector3 direction = rb.transform.position - transform.position;
                    float distance = direction.magnitude;
                    rb.AddForce(direction.normalized * force / distance, ForceMode.Impulse);
                }
            }
        }
    }
}
