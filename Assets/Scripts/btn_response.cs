using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btn_response : MonoBehaviour
{
    public GameObject player;
    public GameObject DieMessage;
    public Animator animator;
    public GameObject Camera;
    public Text count ;
    


    public void response_click()
    {
        animator.Play("Locomotion", -1, 0);
        player.GetComponent<reponse>().ResetFalling();
        DieMessage.SetActive(false);
        Camera.GetComponent<ThirdPersonOrbitCamBasic>().enabled = true;
        player.GetComponent<MoveBehaviour>().enabled = true;
        count.GetComponent<Text>().text = (int.Parse(count.GetComponent<Text>().text)+1).ToString();
        timer ti = GameObject.Find("Canvas1").GetComponent<timer>();
        ti.TimerOn = true;

    }

}
