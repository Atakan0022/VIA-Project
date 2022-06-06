using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class npcsayacı : MonoBehaviour
{

    Text sayac2; 

    void Start()
    {
        sayac2 = GetComponent<Text>();
    }

    
    void Update()
    {
        if (sayac2.text != Attack.killSayisi.ToString())
        {

            sayac2.text = Attack.killSayisi.ToString();

        }
    }
}
