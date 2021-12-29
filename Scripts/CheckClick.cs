using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckClick : MonoBehaviour
{
    public Text score;
    Silicon sil = new Silicon();
    void OnMouseDown()
    {
        sil.silicon++;
        score.text = "Silicon: " + sil.silicon;
    }
}
