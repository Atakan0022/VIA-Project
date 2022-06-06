using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diyalogNpc : MonoBehaviour
{
    public GameObject diyalogKutusu;

    float GörüntülemeZamanlayýcýsý;

    public float GörüntülemeZamaný = 8.0f;


    public void DiyalogAc()
    {
        GörüntülemeZamanlayýcýsý = GörüntülemeZamaný;

        diyalogKutusu.SetActive(true);
    }


    void Start()
    {

        GörüntülemeZamanlayýcýsý = -2.0f;

        diyalogKutusu.SetActive(false);
        
    }


    void Update()
    {
        if (GörüntülemeZamanlayýcýsý >= 0)
        {
            GörüntülemeZamanlayýcýsý -= Time.deltaTime;
            
            if (GörüntülemeZamanlayýcýsý < 0)
            {
                diyalogKutusu.SetActive(false);
            }
        }
    }

   

}