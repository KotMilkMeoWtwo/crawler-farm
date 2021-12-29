using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyAtrax : MonoBehaviour
{
    private int atrax;
    public Text amount;
    private int silicon;
    public Text silic;
    float UpdateDelta;
    public void Start()
    {
        silicon = PlayerPrefs.GetInt("silic");
        atrax = PlayerPrefs.GetInt("atrax");
        amount.text = "Atrax bring 1 silicone in 5 second (+1 sil/5 sec)\nprice: 200\nYou have " + atrax + " atrax" + (atrax == 1 ? "" : "s") + ".";
    }
    void OnMouseDown()
    {
        if (silicon >= 200)
        {
            atrax++;
            amount.text = "Atrax bring 1 silicone in 5 second (+1 sil/5 sec)\nprice: 200\nYou have " + atrax + " atrax" + (atrax == 1 ? "" : "s") + ".";
            silicon -= 200;
            PlayerPrefs.SetInt("silic", silicon);
            PlayerPrefs.Save();
        }
    }
    void Update()
    {
        UpdateDelta += Time.deltaTime;
        if (UpdateDelta >= 5f)
        {
            UpdateDelta = 0;
            if (atrax >= 1)
            {
                silicon += 1 * atrax;
            }
        }
        silic.text = "Silicone: " + silicon;

        PlayerPrefs.SetInt("atrax", atrax);
        PlayerPrefs.SetInt("silic", silicon);
        PlayerPrefs.Save();
    }
}
