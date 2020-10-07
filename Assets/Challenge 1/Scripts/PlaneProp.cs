using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneProp : MonoBehaviour
{
    public float propSpeed = 15f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime*propSpeed);
    }
}
