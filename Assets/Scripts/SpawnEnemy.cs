using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    public GameObject enemyBoss;

    public float maxPosX = 4f;
    public float minPosX = -4;
    public float maxPosZ = 4f;
    public float minPosZ = -4f;

    public float posY = 8;
    
    private int waveNumber = 1;
    private int enemyCount;

    private int bossSpawnLevel = 5;

   
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies(waveNumber);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if(enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemies(waveNumber);
            SpawnPowerUp();
            if(waveNumber % bossSpawnLevel == 0)
            {
                SpawnBoss(1);
            }
        }
    }
    void SpawnEnemies(int enemyNum)
    {
        for(int i = 0; i< enemyNum; i++)
        {
            
            Instantiate(enemyPrefab, randomSpawnPos(), gameObject.transform.rotation);
        }
        
    }
    Vector3 randomSpawnPos()
    {
        float randomPosX = Random.Range(-maxPosX, maxPosX);
        float randomPosZ = Random.Range(-maxPosZ, maxPosZ);
        Vector3 randomSpawnPos = new Vector3(randomPosX, posY, randomPosZ);
        return randomSpawnPos;
    }
    void SpawnPowerUp()
    {
        Vector3 posY = new Vector3(0, 1f, 0);
        Instantiate(powerupPrefab, randomSpawnPos() - posY ,gameObject.transform.rotation);
    }
    void SpawnBoss(int bossNumber)
    {
        for(int i = 0; i< bossNumber; i++)
        {
            Instantiate(enemyBoss, randomSpawnPos(), gameObject.transform.rotation);
        }
        
    }

}
