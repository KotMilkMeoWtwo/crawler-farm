using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiliconSecond : MonoBehaviour
{
    Silicon sil = new Silicon();
    // Update is called once per frame
    void Update()
    {
        sil.silicon++;
        print("update");
    }
    
    private IEnumerator upd()
    {
        sil.silicon++;
        print("meow");
        yield return new WaitForSeconds(1.0f);
    }
}
