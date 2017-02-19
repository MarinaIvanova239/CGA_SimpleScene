using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSphereBehaviourScript : MonoBehaviour {
    
    public float maxHeight = 4.0f;
    private float currentHeight = 0.0f;
    public float step = 0.1f;
    public Vector3 movement = new Vector3(0.0f, 0.1f, 0.0f);

    void Update()
    {
        transform.Translate(movement);
        currentHeight += step;
        if (currentHeight >= maxHeight)
        {
            movement *= -1;
            currentHeight = 0.0f;
        }
    }

}
