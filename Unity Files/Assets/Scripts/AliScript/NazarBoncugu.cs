using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NazarBoncugu : MonoBehaviour
{
    
    public static int toplamNazarBoncugu = 0;

    void start()
    {
        

    }
    void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;

    }

   
    void OnTriggerEnter2D(Collider2D carpma)
    {
        
        if (carpma.CompareTag("Player"))
        {

            toplamNazarBoncugu++;
            
 
            Destroy(gameObject);
        }
    }
}
