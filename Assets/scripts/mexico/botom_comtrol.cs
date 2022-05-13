using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class botom_comtrol : MonoBehaviour
{
    [SerializeField] GameObject vestuario;
    [SerializeField] GameObject letra;
    [SerializeField] GameObject musica;
    [SerializeField] GameObject ecsenario;
    [SerializeField] private int retorno;
    [SerializeField] GameObject botonRegreso;

    bool vestu = true;
    bool letr = true;
    bool mus = true;
    bool esce = true;

    int contador = 0;

    private void Update()
    {
        if (contador==4)
        {
            botonRegreso.SetActive(true);
        }

    }

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
        if (vestu == true)
        {
            contador++;
            vestu = false;
        }

    }
    public void salir_letras()
    {
        letra.SetActive(false);
        if (letr == true)
        {
            contador++;
            letr = false;
        }
    }
    public void salir_musica()
    {
        musica.SetActive(false);
        if (mus == true)
        {
            contador++;
            mus = false;
        }
    }
    public void salir_ecenario()
    {
        ecsenario.SetActive(false);
        if (esce == true)
        {
            contador++;
            esce = false;
        }
    }

    public void regreso()
    {
        SceneManager.LoadScene(retorno);
    }

}
