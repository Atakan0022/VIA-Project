using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelAtla : MonoBehaviour
{
    void Start()
    {   

    }

    void Update()
    {

    }
    //ObjeyeÇarparak Sahneyi Deðiþtiriyoruz.

    void OnCollisionEnter2D(Collision2D atla)
    {
        if (atla.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
