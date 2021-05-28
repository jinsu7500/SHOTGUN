using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class game_over : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            SceneManager.LoadScene("Die_Menu");
        }
    }


}
