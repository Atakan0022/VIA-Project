using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class denemeiki : MonoBehaviour
{
    [SerializeField] int width, height;
    [SerializeField] GameObject zemin, cim;
    void Start()
    {
        Generation();    
    }
    void Generation()
    {
        for (int x= 0; x<width; x++)
        {
            for (int y= 0; y<height; y++)
            {
                Instantiate(zemin, new Vector2(x, y), Quaternion.identity);
            }
            Instantiate(cim, new Vector2(x, height), Quaternion.identity);
        }
    }
}

