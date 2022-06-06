using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanBarý : MonoBehaviour
{
    //Can barýnýn hareket etmesi için slider oluþturuyoruz.
    public Slider canBarý;
    public Health oyuncuCaný;

    public void CanDegeriniGetir(int can)
    {
        canBarý.value = can;
    }



    private void Start()
    {
        oyuncuCaný = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        canBarý = GetComponent<Slider>();

        //Can barýmýzdaki deðerleri karakterin deðerlerine ayarlýyoruz.
        canBarý.maxValue = oyuncuCaný.maxHealth;
        canBarý.value = oyuncuCaný.maxHealth;
    }

    
}
