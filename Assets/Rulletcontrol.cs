using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rulletcontrol : MonoBehaviour
{
    float rotSpeed = 0;
    // Update is called once per frame
    void Update() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10.0f;
        }

        if (Input.GetMouseButtonDown(1))
        {
            this.rotSpeed = 0.0f;
        }
        this.rotSpeed *= 0.987f;
        transform.Rotate(0, 0, this.rotSpeed);
    }
}
