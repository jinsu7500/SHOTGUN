using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTrap : MonoBehaviour
{
    public float rotSpeed = 25f;
    void Update()
    {
        self_Rotation();
    }

    void self_Rotation()
    {
        
        transform.Rotate(new Vector3(rotSpeed * Time.deltaTime, 0, 0));
    }
}
