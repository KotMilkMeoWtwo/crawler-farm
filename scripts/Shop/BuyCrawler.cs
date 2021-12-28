using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyCrawler : MonoBehaviour
{
    private int crawler;
    public Text amount;
    private int silicon;
    public Text silic;
    float UpdateDelta;
    public void Start()
    {
        silicon = PlayerPrefs.GetInt("silic");
        crawler = PlayerPrefs.GetInt("crawler");
    }
    void OnMouseDown()
    {
        if(silicon >= 50)
        {
            crawler++;
            amount.text = "Crawler bring 1 silicone in secend (+1 sil/sec) \nYou have " + crawler + " crawler(s).";
            silicon -= 50;
            PlayerPrefs.SetInt("silic", silicon);
            PlayerPrefs.Save();
        }
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
        silic.text = "Silicone: " + silicon;

        PlayerPrefs.SetInt("crawler", crawler);
        PlayerPrefs.SetInt("silic", silicon);
        PlayerPrefs.Save();
    }
}
