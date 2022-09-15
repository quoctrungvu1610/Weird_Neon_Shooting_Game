using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHead : MonoBehaviour
{
    public float rotateSpeed = 2f;
    public GameObject body;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ControlPlayerHead();
        gameObject.transform.position = body.transform.position + new Vector3(0, 0.3f, 0);
    }
    void ControlPlayerHead()
    {
        float horizontalSpeed = Input.GetAxis("Horizontal");
        gameObject.transform.Rotate(Vector3.up * rotateSpeed * horizontalSpeed * Time.deltaTime);
    }
}
