using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class game_over : MonoBehaviour
{
    public GameObject DieMessage;
    public GameObject Player;
    public GameObject Camera;
    public Animator animator;



    private void OnTriggerEnter(Collider col)
    {
        DieMessage = GameObject.Find("Canvas").transform.Find("DieMessage").gameObject;
        if (col.tag == "Player")
        {
            DieMessage.SetActive(true);
            
            timer ti = GameObject.FindWithTag("timer").GetComponent<timer>();
            ti.TimerOn = false;
            Camera.GetComponent<ThirdPersonOrbitCamBasic>().enabled = false;
            Player.GetComponent<MoveBehaviour>().enabled = false;
            animator.Play("Locomotion", -1, 0);
            animator.Play("Falling Back Death", -1, 0);


        }
    }

    public void GameOver() // ÇÁ¸®ÆÕ¿ë
    {
        DieMessage.SetActive(true);
        Camera.GetComponent<ThirdPersonOrbitCamBasic>().enabled = false;
        Player.GetComponent<MoveBehaviour>().enabled = false;
        animator.Play("Locomotion", -1, 0);
        animator.Play("Falling Back Death", -1, 0);
    }

}
