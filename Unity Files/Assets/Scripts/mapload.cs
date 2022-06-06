using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapload : MonoBehaviour
{
   public static mapload instance;
   public GameObject ObaCam;
   public GameObject GirisCam;
   public GameObject Vadi1Cam;
   public GameObject Vadi2Cam;
   public GameObject Vadi3Cam;
   public GameObject player;
   public GameObject oba_baslangic;
   public GameObject giris_baslangic;
   public GameObject vadi1_baslangic;
   public GameObject vadi2_baslangic;
   public GameObject vadi3_baslangic;
   
   void Awake(){
	   DontDestroyOnLoad(gameObject);
	   instance=this;
   }
   
   public void obayagec(){
	   ObaCam.SetActive(true);
	   GirisCam.SetActive(false);
	   Vadi1Cam.SetActive(false);
	   Vadi2Cam.SetActive(false);
	   Vadi3Cam.SetActive(false);
	   player.transform.position= oba_baslangic.transform.position;
   }
   public void girisgec(){
	   ObaCam.SetActive(false);
	   GirisCam.SetActive(true);
	   Vadi1Cam.SetActive(false);
	   Vadi2Cam.SetActive(false);
	   Vadi3Cam.SetActive(false);
	      player.transform.position= giris_baslangic.transform.position;
   }
   public void vadi1gec(){
	   ObaCam.SetActive(false);
	   GirisCam.SetActive(false);
	   Vadi1Cam.SetActive(true);
	   Vadi2Cam.SetActive(false);
	   Vadi3Cam.SetActive(false);
	    player.transform.position= vadi1_baslangic.transform.position;
   }
   public void vadi2gec(){
	   ObaCam.SetActive(false);
	   GirisCam.SetActive(false);
	   Vadi1Cam.SetActive(false);
	   Vadi2Cam.SetActive(true);
	   Vadi3Cam.SetActive(false);
	     player.transform.position= vadi2_baslangic.transform.position;
   }
   public void vadi3gec(){
	   ObaCam.SetActive(false);
	   GirisCam.SetActive(false);
	   Vadi1Cam.SetActive(false);
	   Vadi2Cam.SetActive(false);
	   Vadi3Cam.SetActive(true);
	    player.transform.position= vadi3_baslangic.transform.position;
   }
}
