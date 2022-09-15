using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSupply : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotateSpeed = 6;
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotateAngle = new Vector3(0, rotateSpeed, 0);
        transform.Rotate(rotateAngle);
        transform.position = player.transform.position;
    }
}
