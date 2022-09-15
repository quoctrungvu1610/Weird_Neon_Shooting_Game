using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneController : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject masterToFollow;
    Rigidbody droneRb;
    public GameObject droneWing;
    public float rotateSpeed = 2f;

    public GameObject shootPoint1;
    public GameObject shootPoint2;
    public GameObject shootPoint3;
    public GameObject shootPoint4;

    public GameObject heavyBullet;

    void Start()
    {
        masterToFollow = GameObject.Find("HeadCam");
        droneRb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 masterPos = masterToFollow.gameObject.transform.position;
        Vector3 positionToFollow = masterPos - gameObject.transform.position;
        droneRb.AddForce(positionToFollow * 2);
        Vector3 rotateAngle = new Vector3(0, rotateSpeed, 0);
        droneWing.gameObject.transform.Rotate(rotateAngle);
        droneWing.transform.position = gameObject.transform.position;
        if (Input.GetKeyDown(KeyCode.C))
        {
            ShootHeavyBullet();
        }
        
    }
    void ShootHeavyBullet()
    {
       
            Instantiate(heavyBullet, shootPoint1.transform.position, shootPoint1.transform.rotation);
            Instantiate(heavyBullet, shootPoint2.transform.position, shootPoint2.transform.rotation);
            Instantiate(heavyBullet, shootPoint3.transform.position, shootPoint3.transform.rotation);
            Instantiate(heavyBullet, shootPoint4.transform.position, shootPoint4.transform.rotation);
        
    }
}
