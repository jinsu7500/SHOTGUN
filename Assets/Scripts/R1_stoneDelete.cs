using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R1_stoneDelete : MonoBehaviour
{ 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // gameObject.transform.position = Vector3.Slerp(gameObject.transform.position, m_tfTarget.transform.position, sLerpSpeed);
        //transform.Translate(Vector3.forward * sLerpSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Terrain")
        {
           Destroy(gameObject,5);
        }

        else if (collision.collider.tag == "Player")
        {
            Debug.Log("투석기맞고 사망");
            //gameOverSystem.GetComponent<game_over>().GameOver();
        }

    }
}
