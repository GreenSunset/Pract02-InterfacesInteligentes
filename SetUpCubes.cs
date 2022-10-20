using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUpCubes : MonoBehaviour
{
    void Awake()
    {
        ScaleWithDistance scale = gameObject.GetComponent<ScaleWithDistance>();
        if (scale != null)
        {
            scale.growingFocus = GameObject.FindGameObjectWithTag("Player2").transform;
            scale.shrinkingFocus = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }
}
