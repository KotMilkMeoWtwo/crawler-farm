using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public int silicon=0;
    public Text sil;
    private int crawler;
    float UpdateDelta;
    private int atrax;
    void Start()
    {
        atrax = PlayerPrefs.GetInt("atrax");
        crawler = PlayerPrefs.GetInt("crawler");
        silicon = PlayerPrefs.GetInt("silic");
        sil.text = "Silicone: " + silicon;
        // print("loadd");
    }
    void OnMouseDown()
    {
        
        silicon++;
        sil.text="Silicone: " + silicon;
    }
    private float UpdateDelta2;
    void Update()
    {
        UpdateDelta += Time.deltaTime;
        if (UpdateDelta >= 10f)
        {
            UpdateDelta = 0;
            if (crawler >= 1)
            {
                silicon += 1 * crawler;
            }
        }
        UpdateDelta2 += Time.deltaTime;
        if (UpdateDelta2 >= 5f)
        {
            UpdateDelta2 = 0;
            if (atrax >= 1)
            {
                silicon += 1 * atrax;
            }
        }
        sil.text = "Silicone: " + silicon;
        PlayerPrefs.SetInt("silic", silicon);
        PlayerPrefs.Save();
        // print("save");
    }
}
