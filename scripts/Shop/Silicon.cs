using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Silicon : MonoBehaviour
{
    public Text sil;
    public int silicon;
    public void Start()
    {
        silicon = PlayerPrefs.GetInt("silic");
        sil.text = "Silicon: " + silicon;
    }
    // Update is called once per frame
    void Update()
    {

        silicon = PlayerPrefs.GetInt("silic");
        sil.text = "Silicon: " + silicon;
    }
}
