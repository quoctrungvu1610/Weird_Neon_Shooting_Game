using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BossHealth : MonoBehaviour
{
    public Slider bossHealth;
    public int maxHealth = 10;
    private int currentHealth = 10;

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        bossHealth.maxValue = maxHealth;
        bossHealth.value = maxHealth;
        player = GameObject.Find("Head");
    }

    // Update is called once per frame
    void Update()
    {
        bossHealth.gameObject.transform.rotation = player.transform.rotation;
    }
    public void HitTheBoss(int damage)
    {
        currentHealth -= damage;
        bossHealth.fillRect.gameObject.SetActive(true);
        bossHealth.value = currentHealth;
        if(currentHealth == 0)
        {
            Destroy(gameObject);
        }
    }
}
