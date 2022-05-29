using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Diyalog : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] satir;
    public float hiz;

    private int index;


    void Start()
    {
        textComponent.text = string.Empty;
        DiyalogBasla();
    }

    void DiyalogBasla()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == satir[index])
            {
                SonrakiSatir();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = satir[index];
            }
        }
    }

    IEnumerator TypeLine()
    {
        foreach (char c in satir[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(hiz);
        }
    }

    void SonrakiSatir()
    {
        if (index < satir.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
