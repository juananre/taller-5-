using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botom_comtrol : MonoBehaviour
{
    [SerializeField] GameObject vestuario;
    [SerializeField] GameObject letra;
    [SerializeField] GameObject musica;
    [SerializeField] GameObject ecsenario;

    public void ver_vestuario()
    {
        vestuario.SetActive(true);
    }
    public void ver_letras()
    {
        letra.SetActive(true);
    }
    public void ver_musica()
    {
        musica.SetActive(true);
    }
    public void ver_ecenario()
    {
        ecsenario.SetActive(true);
    }



    public void salir_vestuario()
    {
        vestuario.SetActive(false);
    }
    public void salir_letras()
    {
        letra.SetActive(false);
    }
    public void salir_musica()
    {
        musica.SetActive(false);
    }
    public void salir_ecenario()
    {
        ecsenario.SetActive(false);
    }

}
