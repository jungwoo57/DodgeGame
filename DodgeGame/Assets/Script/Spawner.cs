using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float minRate;
    public float maxRate;

    private Transform target;
    private float spawnRate;
    private float spawnTime = 0;
    private float timeAfterSpawn;

    private void Start()
    {
        timeAfterSpawn = 0.0f;
        spawnRate = Random.Range(minRate, maxRate);
        target = FindObjectOfType<Player>().transform;
    }
    private void Update()
    {
        Spawn();
    }
    void Spawn() 
    {
        spawnTime += Time.deltaTime;
        if(spawnTime >= spawnRate){
            GameObject bullet = Instantiate(bulletPrefab,transform.position, transform.rotation);
            bullet.transform.LookAt(target);
            bullet.GetComponent<Bullet>();
            spawnRate = Random.Range(minRate, maxRate);
            spawnTime = 0.0f;
        }
    }
}
