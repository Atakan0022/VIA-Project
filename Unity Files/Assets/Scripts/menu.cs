using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
	public GameObject pausing;
   public void start(){
	   SceneManager.LoadSceneAsync(1);
   }
   public void exit(){
	   Application.Quit();
   }
   public void Pause(){
	   pausing.SetActive(true);
	  Time.timeScale=1;
   }
   public void devam(){
	  pausing.SetActive(false);
	  Time.timeScale=1;
   }
}
