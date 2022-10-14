using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushAwayNear : MonoBehaviour
{
    public float pushAwayForce = 10f;
    private void OnTriggerEnter(Collider other)
    {
        // get the rigidbody of the other object
        Rigidbody otherRigidbody = other.GetComponent<Rigidbody>();
        // if the other object has a rigidbody
        if (otherRigidbody != null)
        {
            // get the direction from this object to the other object
            Vector3 direction = other.transform.position - transform.position;
            float distance = direction.magnitude;
            // normalize the direction
            direction.Normalize();
            // push the other object away
            otherRigidbody.AddForce(direction * pushAwayForce / Mathf.Pow(distance, 2));
        }
    }
}
