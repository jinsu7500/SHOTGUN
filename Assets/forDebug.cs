using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class forDebug : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F9))
            SceneManager.LoadScene("Round1");
        if (Input.GetKeyDown(KeyCode.F10))
            SceneManager.LoadScene("Round2");
        if (Input.GetKeyDown(KeyCode.F11))
            SceneManager.LoadScene("Round3");

    }
}
