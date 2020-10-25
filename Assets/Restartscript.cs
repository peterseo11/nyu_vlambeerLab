using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Restartscript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
           SceneManager.LoadScene("mainLabScene"); // Load Main Scene
        }

    }
}
