using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoss : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            gameObject.GetComponent<BossHealth>().HitTheBoss(1);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("PowerfulBullet"))
        {
            gameObject.GetComponent<BossHealth>().HitTheBoss(3);
            Destroy(collision.gameObject);
        }
    }
}
