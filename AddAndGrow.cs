using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddAndGrow : MonoBehaviour
{
    public float growFactor = 1.1f;
    private void OnCollisionEnter(Collision other)
    {
        PointTracker otherPointTracker = other.gameObject.GetComponent<PointTracker>();
        if (otherPointTracker != null)
        {
            otherPointTracker.AddPoints();
            transform.localScale *= growFactor;
            GetComponent<Rigidbody>().mass *= growFactor;
        }
    }
}
