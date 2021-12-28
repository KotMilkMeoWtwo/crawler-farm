using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainScene : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
