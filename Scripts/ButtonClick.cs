using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    void OnMouseDown()
    {
        transform.localScale = new Vector3(0.03398081f, 0.03398081f, 0.03398081f);

    }
    void OnMouseUp()
    {
        transform.localScale = new Vector3(0.02398081f, 0.02398081f, 0.02398081f);

    }
}
