using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diyalogNpc : MonoBehaviour
{
    public GameObject diyalogKutusu;

    float GörüntülemeZamanlayıcısı;

    public float GörüntülemeZamanı = 8.0f;


    public void DiyalogAc()
    {
        GörüntülemeZamanlayıcısı = GörüntülemeZamanı;

        diyalogKutusu.SetActive(true);
    }


    void Start()
    {

        GörüntülemeZamanlayıcısı = -2.0f;

        diyalogKutusu.SetActive(false);
        
    }


    void Update()
    {
        if (GörüntülemeZamanlayıcısı >= 0)
        {
            GörüntülemeZamanlayıcısı -= Time.deltaTime;
            
            if (GörüntülemeZamanlayıcısı < 0)
            {
                diyalogKutusu.SetActive(false);
            }
        }
    }

   

}