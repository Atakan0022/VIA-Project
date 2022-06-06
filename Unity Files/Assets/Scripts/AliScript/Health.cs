using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 100;
    
    public CanBarý canBarý;

   
    

    void Start()
    {
        curHealth = maxHealth;
    }

    void Update()
    {

        if (curHealth <= 0)
        {
            SceneManager.LoadScene("Finish");
        }

        if (NazarBoncugu.toplamNazarBoncugu == 4)
        {
            SceneManager.LoadScene("YouWin");
        }
        
        if (Attack.killSayisi == 0)
        {
            SceneManager.LoadScene("YouWin");
        }
    }

     public void DamagePlayer(int damage)
     {
         curHealth -= damage;

         canBarý.CanDegeriniGetir(curHealth);
     } 


    

   
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "NPC")
        {
            DamagePlayer(10);
        }
    }
}