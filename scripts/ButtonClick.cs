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

    void Start()
    {
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

    void Update()
    {
        UpdateDelta += Time.deltaTime;
        if (UpdateDelta >= 1f)
        {
            UpdateDelta = 0;
            if (crawler >= 1)
            {
                silicon += 1 * crawler;
            }
        }
        sil.text = "Silicone: " + silicon;
        PlayerPrefs.SetInt("silic", silicon);
        PlayerPrefs.Save();
        // print("save");
    }
}
