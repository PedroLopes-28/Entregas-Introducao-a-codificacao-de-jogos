using System;
using UnityEditor.UI;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{

    private Material m;
    float velocidade=0.3f;
    private float offsetX;
     void Awake()
     {
         m=GetComponent<SpriteRenderer>().material;
         
     }
    // Update is called once per frame
    void Update()
    {
        offsetX = m.mainTextureOffset.x + (velocidade*Time.deltaTime);
        
        m.mainTextureOffset = new Vector2(x: offsetX, y: 0);
    }
}
