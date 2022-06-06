using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunaDevam : MonoBehaviour
{
    [SerializeField] GameObject durMenusu;

    // butona týklayýnca bu fonksiyon timeScale 1 olup oyun devam edicek.
    public void Devam()
    {
        durMenusu.SetActive(false);

        Time.timeScale = 1f;

    }
}
