using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_cam : MonoBehaviour
{
    public GameObject cube;
    public GameObject cube1;
    public void Start_Cam()
    {
        cube.GetComponent<ThirdPersonOrbitCamBasic>().enabled = true;
        cube1.GetComponent<BasicBehaviour>().enabled = true;
        cube1.GetComponent<MoveBehaviour>().enabled = true;
    }
}
