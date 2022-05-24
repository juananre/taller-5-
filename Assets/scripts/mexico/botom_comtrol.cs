using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class botom_comtrol : MonoBehaviour
{
    [SerializeField] AudioSource general;
    [SerializeField] AudioClip voz_retorno;
    [SerializeField] private float tiempo_aparicion_boton = 1f;


    [SerializeField] GameObject vestuario;
    [SerializeField] GameObject letra;
    [SerializeField] GameObject musica;
    [SerializeField] GameObject ecsenario;
    [SerializeField] private int retorno;
    [SerializeField] GameObject botonRegreso;
    [SerializeField] GameObject mesajeResgreso;

    [SerializeField] private float tiempo_fate = 2f;

    private Animator fade;

    bool vestu = true;
    bool letr = true;
    bool mus = true;
    bool esce = true;

    int contador = 0;


    void Awake()
    {
        fade = GetComponentInChildren<Animator>();

    }
    private void Update()
    {
        if (contador==4)
        {
            general.PlayOneShot(voz_retorno);
            tiempo_aparicion_boton -= Time.deltaTime;
            if (tiempo_aparicion_boton<=0)
            {
                botonRegreso.SetActive(true);
                mesajeResgreso.SetActive(true);
            }
           
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
        StartCoroutine(fade_retorno(retorno));
    }

    public IEnumerator fade_retorno(int retorno)
    {
        fade.SetTrigger("fade out");
        yield return new WaitForSeconds(tiempo_fate);
        SceneManager.LoadScene(retorno);
    }
}
