using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondSphereBehaviourScript : MonoBehaviour {

    public float rotationSpeed = 6.0f;

    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, 360.0f / rotationSpeed * Time.deltaTime);
    }
}
