using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushAwayShy : MonoBehaviour
{
    public float pushAwayForce = 10f;
    private void OnTriggerStay(Collider other)
    {
        Rigidbody otherRigidbody = other.GetComponent<Rigidbody>();
        if (otherRigidbody != null && other.gameObject.tag == "Shy")
        {
            Vector3 direction = other.transform.position - transform.position;
            float distance = direction.magnitude;
            direction.Normalize();
            otherRigidbody.AddForce(direction * pushAwayForce / Mathf.Pow(distance, 2));
        }
    }
}
