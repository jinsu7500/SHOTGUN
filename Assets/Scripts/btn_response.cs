using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn_response : MonoBehaviour
{
    public GameObject player;
    public GameObject DieMessage;
    public Animator animator;
    public GameObject Camera;



    public void response_click()
    {
        animator.Play("Locomotion", -1, 0);
        player.GetComponent<reponse>().ResetFalling();
        DieMessage.SetActive(false);
        Camera.GetComponent<ThirdPersonOrbitCamBasic>().enabled = true;
        player.GetComponent<MoveBehaviour>().enabled = true;
    }
}
