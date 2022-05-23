using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonton_Tiempo : MonoBehaviour
{
    public float tiemp_Inicial_segundos;
    [SerializeField] GameObject botoes;



    void Update()
    {
        tiemp_Inicial_segundos -= Time.deltaTime;
        if (tiemp_Inicial_segundos <= 0) 
        {
            botoes.SetActive(true);
            
         
        }
    }
}
