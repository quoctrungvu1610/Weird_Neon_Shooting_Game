using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float bulletSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);
        if(gameObject.transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
