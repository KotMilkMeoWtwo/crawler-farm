using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SilSec : MonoBehaviour
{
    
    Silicon sil = new Silicon();
    void OnMouseDown()
    {
        print("meow");
    }
    private IEnumerator upd()
    {
        sil.silicon++;
        print("meow");
        yield return new WaitForSeconds(0.1f);
    }
    void Start()
    {
        StartCoroutine(upd());
    }

}
