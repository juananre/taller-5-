using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_cotrol_time : MonoBehaviour
{
    public float tiemp_Inicial_mexico;
    public float tiemp_Inicial_sur;
    public float tiemp_Inicial_norte;
    [SerializeField] AudioSource general;

    [SerializeField] AudioClip audio_mex;
    [SerializeField] AudioClip audio_sur;
    [SerializeField] AudioClip audio_centro;

    [SerializeField] GameObject esfera_mexico;
    [SerializeField] GameObject esfera_sur;
    [SerializeField] GameObject esfera_centro;

    void Update()
    {
        tiemp_Inicial_mexico -= Time.deltaTime;
        tiemp_Inicial_sur -= Time.deltaTime;
        tiemp_Inicial_norte -= Time.deltaTime;
        if (tiemp_Inicial_mexico <= 0)
        {
            general.PlayOneShot(audio_mex);

            esfera_mexico.SetActive(true);
           
        }
        if (tiemp_Inicial_sur <= 0)
        {
            general.PlayOneShot(audio_sur);


            esfera_sur.SetActive(true);
       
        }
        if (tiemp_Inicial_norte <=0)
        {
            general.PlayOneShot(audio_centro);

            esfera_centro.SetActive(true);
        }
    }
}
