using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// UI kodu. Toplanan nazar boncuğunu sayısını gösteriyoruz.
public class nazarBoncuğuSayacı : MonoBehaviour
{
    Text sayac;

   

    void Start()
    {
        sayac = GetComponent<Text>();
    }

    
    void Update()
    {
       
        if (sayac.text != NazarBoncugu.toplamNazarBoncugu.ToString())
        {
            sayac.text = NazarBoncugu.toplamNazarBoncugu.ToString();
        }
    }
}