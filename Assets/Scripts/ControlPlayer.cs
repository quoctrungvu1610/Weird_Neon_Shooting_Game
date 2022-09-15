using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerSpeed = 10f;
    Rigidbody playerRb;
    public GameObject playerHead;
    public GameObject bullet;
    public GameObject powerfulBullet;

    public GameObject shootPoint;
    public GameObject shootPoint2;
    public GameObject shootPoint3;
    public GameObject shootPoint4;

    public float bonusForce = 100f;
    public GameObject powerIndicator;

    public bool hasPower = false;
    
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerHead = GameObject.Find("Head");
    }

    // Update is called once per frame
    void Update()
    {
        float verticalSpeed = Input.GetAxis("Vertical");
        playerRb.AddForce(playerHead.transform.forward * playerSpeed * verticalSpeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, shootPoint.transform.position,shootPoint.transform.rotation );
        }
        if (Input.GetKeyDown(KeyCode.Space) && hasPower)
        {
            Instantiate(bullet, shootPoint.transform.position, shootPoint.transform.rotation);
            Instantiate(bullet, shootPoint2.transform.position, shootPoint2.transform.rotation);
            Instantiate(bullet, shootPoint3.transform.position, shootPoint3.transform.rotation);
            Instantiate(powerfulBullet, shootPoint4.transform.position, shootPoint4.transform.rotation);
        }
        if (hasPower == true)
        {
            powerIndicator.SetActive(true);
        }
        else if(hasPower == false)
        {
            powerIndicator.SetActive(false);
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PowerSupply"))
        {
            Destroy(other.gameObject);
            StartCoroutine(countdownPowerup());
            hasPower = true;
        }
    }
   
    IEnumerator countdownPowerup()
    {
       yield return new WaitForSeconds(5);
        hasPower = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Enemy") && hasPower)
        {
            Vector3 pushEnemyBack = collision.transform.position - transform.position;
            collision.gameObject.GetComponent<Rigidbody>().AddForce(pushEnemyBack * bonusForce, ForceMode.Impulse);


        }
    }
}
