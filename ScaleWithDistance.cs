using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleWithDistance : MonoBehaviour
{
    public Transform growingFocus;
    public Transform shrinkingFocus;
    public float maxScale = 5f;
    public float minScale = 0.1f;
    
    void Update()
    {
        float middleDistance = (maxScale + minScale) / 2;
        float distanceDifference = Vector3.Distance(shrinkingFocus.position, transform.position) - Vector3.Distance(growingFocus.position, transform.position);
        float maxDistance = Mathf.Abs(Vector3.Distance(growingFocus.position, shrinkingFocus.position));
        float scale;
        if (distanceDifference > 0)
        {
            scale = Mathf.Lerp(middleDistance, maxScale, distanceDifference / maxDistance);
        }
        else
        {
            scale = Mathf.Lerp(middleDistance, minScale, -distanceDifference / maxDistance);
        }
        // float scale = Mathf.Clamp((distanceDifference / maxDistance) * (maxScale - minScale) + minScale, minScale, maxScale);
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
