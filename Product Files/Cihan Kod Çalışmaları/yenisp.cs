using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yenisp : MonoBehaviour
{
    public GameObject [] enemy;
    public Transform[] spawnp;
    float randX;
    Vector2 nereyeSpawn;
    public float spawnsuresi;
    float siradakispawn;
    
    void Start()
    {       
    }
    void Update()
    {
        if (Time.time > siradakispawn)
        {
            siradakispawn = Time.time + spawnsuresi;
            randX = Random.Range(-45f, 73f);
            nereyeSpawn = new Vector2 (randX, transform.position.y);
            //Instantiate(enemy, nereyeSpawn, Quaternion.identity);
            // Instantiate(enemy[Random.Range(0, enemy.Length)]);
            //Instantiate(enemy[Random.Range(0, enemy.Length)], spawnp[Random.Range(0, spawnp.Length)].position, Quaternion.identity);
            for (int i = 0; i < 6; i++)
            {
                Instantiate(enemy[Random.Range(0, enemy.Length)], spawnp[Random.Range(0, spawnp.Length)].position, Quaternion.identity);
            }
        }
    }
}
