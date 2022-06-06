using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Basla : MonoBehaviour
{ 
    // Ana ekranda butona atanacak olan fonksiyon.
    public void BaslaOyun()
    {
        SceneManager.LoadScene("oba1");
    }

}

