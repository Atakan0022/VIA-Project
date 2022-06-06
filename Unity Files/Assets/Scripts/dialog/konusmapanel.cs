using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class konusmapanel : MonoBehaviour
{
	public static konusmapanel instance;
	public bool konusma_var=false;
	public GameObject pencere;
	public TextMeshProUGUI isim;
	public TextMeshProUGUI yazi;
	void Awake(){
		DontDestroyOnLoad(gameObject);
		instance=this;
		pencere.SetActive(false);
		isim.text="";
		yazi.text="";
	}
	
	public void pencere_ac(){
		if(konusma_var==true){
			pencere.SetActive(true);
		}
		else{pencere.SetActive(false);}
	}
}
