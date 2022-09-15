using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePowerSupply : MonoBehaviour
{
    public float rotateSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotateAngle = new Vector3(0, rotateSpeed, 0);
        transform.Rotate(rotateAngle);
    }
}
