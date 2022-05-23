using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class quitGame : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            OyundanCýk();
        }
        
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("Start");
        }


    }

     public void OyundanCýk()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
