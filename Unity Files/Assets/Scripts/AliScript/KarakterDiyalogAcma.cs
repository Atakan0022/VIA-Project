using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class KarakterDiyalogAcma : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        
        

    }
  
    // karakter ve diyalog kuracaðýmýz gameObject çarpýþýnca diyalog açýlcak.
    void OnCollisionEnter2D(Collision2D d)
     {
        diyalogNpc karakter = d.collider.GetComponent<diyalogNpc>();

        if (karakter != null)
        {
            karakter.DiyalogAc();
            // Buraya Dede korkutla konuþup deðiþecek olan statlar eklenecek. Her görev için farklý olucaðýndan bu kýsým boþ.
        }
             
       

    }  

}
