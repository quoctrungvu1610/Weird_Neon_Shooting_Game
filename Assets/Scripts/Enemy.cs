using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject player;
    public float speed;
    Rigidbody enemyRb;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("HeadCam");
        enemyRb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = player.transform.position;
        Vector3 moveToPlayer = playerPos - transform.position;
        enemyRb.AddForce(moveToPlayer * speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("PowerfulBullet"))
        {
            Destroy(gameObject);
        }
    }
}
