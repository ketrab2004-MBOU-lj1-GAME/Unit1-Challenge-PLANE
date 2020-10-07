using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    public float rotSpeed = 45f;
    public Vector3 rotAxis = Vector3.forward;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotAxis, rotSpeed*Time.deltaTime);
    }
}
