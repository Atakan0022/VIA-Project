using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class etkilesimler : MonoBehaviour
{
	
	public string[] yazilar;
	public string[] konusan;
	public string kim;
	int index=0;
	void Start(){
		mapload.instance.obayagec();
		yazilar=new string[10];
		konusan=new string[10];
	}
    void OnTriggerEnter2D(Collider2D d){
		if(d.gameObject.CompareTag("dedekorkut")){
			konusmapanel.instance.konusma_var=true;
			index = 0;
			kim="dedekorkut";
			konusan[0]="Dede Korkut";
			yazilar[0]="Eyy Oğul önündeki vadilere kötülük çökmüş durumda... Senin vazifen kötülüğü yenip obamıza huzuru ve barışı getirmek. ";
			konusan[1]="Dede Korkut";
			yazilar[1]="Bunun için sırasıyla vadileri araştırıp kötülüklerin kaynağını bulup yok etmelisin!!!!";
			konusan[2]="Dede Korkut";
			yazilar[2]="1. Vadi Önünde : Eyy oğul burası 1.vadi burayı TEPE GÖZ denen bir mitolojik varlık ele geçirdi... Görevin 40 tepe gözü yenip vadiyi özgürleştirmen. ";
			konusan[3]="Dede Korkut";
			yazilar[3]="2. Vadi Önünde : Eyy oğul burası 2.vadi burayı GUL YABANİ denen bir mitolojik varlık ele geçirdi... Görevin 50  gul yabaniyi yenip vadiyi özgürleştirmen.";
			konusan[4]="Dede Korkut";
			yazilar[4]="2. Vadi Önünde : Eyy oğul burası 2.vadi burayı GUL YABANİ denen bir mitolojik varlık ele geçirdi... Görevin 50  gul yabaniyi yenip vadiyi özgürleştirmen.";
			konusmapanel.instance.pencere_ac();
		}

		if(d.gameObject.CompareTag("kuru_et")){
			konusmapanel.instance.konusma_var=true;
			index = 0;
			kim="kuru_et";
			konusan[0]="Kurutulmuş Et";
			yazilar[0]=" Etin Güneş önünde bırakılarak ( Çoğunlukla bir cubuk ile havaya asılarak) kurutulma işlemi gerçekleştirilir. Tuzlama işlemi de kemik kısmına yapılır. Türkler Anadoluya geçtikten sonra da bu et tüketimine devam etti.";
			konusmapanel.instance.pencere_ac();
		}
		if(d.gameObject.CompareTag("cadir")){
			konusmapanel.instance.konusma_var=true;
			index = 0;
			kim="cadir";
			konusan[0]="Türk Çadırı";
			yazilar[0]="Göçebe yaşam için olmazsa olmazdır. Hun ve Kök Türk devletlerinde kullanımı sıkça görülür. Yapımında çubuk, keçe ve ip kullanılmıştır.";

			konusmapanel.instance.pencere_ac();
		}
		if(d.gameObject.CompareTag("oba_kapi")){
			mapload.instance.girisgec();
		}
		if(d.gameObject.CompareTag("odunluk")){
			konusmapanel.instance.konusma_var=true;
			index = 0;
			kim="odunluk";
			konusan[0]="ali";
			yazilar[0]="asdasfasfas";
			konusan[1]="dede";
			yazilar[1]="a123";
			konusmapanel.instance.pencere_ac();
		}
		if(d.gameObject.CompareTag("giris_kapi")){
			mapload.instance.obayagec();
		}
		if(d.gameObject.CompareTag("vadi1_kapi")){
			mapload.instance.vadi1gec();
			yenisp.instance.dusmangelsin();
		}

		if(d.gameObject.CompareTag("vadi2_kapi")){
				mapload.instance.vadi2gec();
				yenisp.instance.dusmangelsin();
		}
		if(d.gameObject.CompareTag("girisedon")){
				mapload.instance.girisgec();
		}
		if(d.gameObject.CompareTag("vadi3_kapi")){
				mapload.instance.vadi3gec();
				yenisp.instance.dusmangelsin();
		}
	}
	
	
	
	public void Diyalog_ac(){
		konusmapanel.instance.isim.text="";
		konusmapanel.instance.yazi.text="";
		StartCoroutine(ekle(yazilar,konusan,index));
		index++;
		if(index==5 && kim=="dedekorkut"){konusmapanel.instance.konusma_var=false;konusmapanel.instance.pencere_ac();}
		else if(index==2 && kim=="kuru_et"){konusmapanel.instance.konusma_var=false;konusmapanel.instance.pencere_ac();}
		else if(index== 2&& kim=="cadir"){konusmapanel.instance.konusma_var=false;konusmapanel.instance.pencere_ac();}
		else if(index==3 && kim=="oba_kapi"){konusmapanel.instance.konusma_var=false;konusmapanel.instance.pencere_ac();}
		else if(index==3 && kim=="odunluk"){konusmapanel.instance.konusma_var=false;konusmapanel.instance.pencere_ac();}
		
	}
	
	IEnumerator ekle(string[] yazilar,string[] konusan,int index){
		konusmapanel.instance.isim.text+= konusan[index];
		konusmapanel.instance.yazi.text+=yazilar[index];
		yield return new WaitForSeconds(0.05f);
		
	}
}
