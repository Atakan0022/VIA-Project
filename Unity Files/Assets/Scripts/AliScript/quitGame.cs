using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class quitGame : MonoBehaviour
{
    // Oyunu kapatma butonuna eklencek Script.
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            OyundanCýk();
        }

    }

     public void OyundanCýk()
    {
        Application.Quit();
    }
}
