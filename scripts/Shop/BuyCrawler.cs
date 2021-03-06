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
        amount.text = "Crawler bring 1 silicone in 10 second (+1 sil/10 sec)\nprice: 50\nYou have " + crawler + " crawler" + (crawler == 1 ? "" : "s") + ".";
    }
    void OnMouseDown()
    {
        if(silicon >= 50)
        {
            crawler++;
            amount.text = "Crawler bring 1 silicone in 10 second (+1 sil/10 sec)\nprice: 50\nYou have " + crawler + " crawler" + (crawler == 1 ? "" : "s") + ".";
            silicon -= 50;
            PlayerPrefs.SetInt("silic", silicon);
            PlayerPrefs.Save();
        }
    }
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
        silic.text = "Silicone: " + silicon;

        PlayerPrefs.SetInt("crawler", crawler);
        PlayerPrefs.SetInt("silic", silicon);
        PlayerPrefs.Save();
    }
}
