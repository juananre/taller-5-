using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Skybox : MonoBehaviour
{
    public float RotateSpeed = 1.2f;
    // Update is called once per frame
    void Update()
    {
       
       GetComponent<Skybox>().material.SetFloat("_Rotation", Time.time * 1.23f);
    }
}
