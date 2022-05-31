using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class botom_comtrol : MonoBehaviour
{

    [SerializeField] AudioSource voz_retorno;
    
    
    [SerializeField] private float tiempo_aparicion_boton = 1f;

    [SerializeField] GameObject vestuario;
    [SerializeField] GameObject letra;
    [SerializeField] GameObject musica;
    [SerializeField] GameObject ecsenario;
    [SerializeField] private int retorno;
    [SerializeField] GameObject botonRegreso;

    public float tiemp_seg;
    public int tiempo_reinicio;

    [SerializeField] private float tiempo_fate = 2f;

    private Animator fade;

    bool vestu = true;
    bool letr = true;
    bool mus = true;
    bool esce = true;

    int contador = 0;

   
    void Awake()
    {
        voz_retorno = GetComponent<AudioSource>();
        fade = GetComponentInChildren<Animator>();
    }
    private void Update()
    {
        if (contador == 4)
        {
            voz_retorno.enabled = true;
            tiempo_aparicion_boton -= Time.deltaTime;
            
            if (tiempo_aparicion_boton<=0)
            {
                botonRegreso.SetActive(true);
                
            }
           
        }

    }

    public void ver_vestuario()
    {
        vestuario.SetActive(true);
        tiemp_seg -= Time.deltaTime;
    }
    public void ver_letras()
    {
        letra.SetActive(true);
        tiemp_seg -= Time.deltaTime;
    }
    public void ver_musica()
    {
        musica.SetActive(true);
        tiemp_seg -= Time.deltaTime;
    }
    public void ver_ecenario()
    {
        ecsenario.SetActive(true);
        tiemp_seg -= Time.deltaTime;
    }



    public void salir_vestuario()
    {
        if (tiemp_seg == 0)
        {
            vestuario.SetActive(false);
            tiemp_seg = tiempo_reinicio;
        }
        
        if (vestu == true)
        {
            contador++;
            vestu = false;
        }

    }
    public void salir_letras()
    {
        if (tiemp_seg == 0)
        {
            letra.SetActive(false);
            tiemp_seg = tiempo_reinicio;
        }
        
        if (letr == true)
        {
            contador++;
            letr = false;
        }
    }
    public void salir_musica()
    {
        if (tiemp_seg == 0)
        {
            musica.SetActive(false);
            tiemp_seg = tiempo_reinicio;
        }
        
        if (mus == true)
        {
            contador++;
            mus = false;
        }
    }
    public void salir_ecenario()
    {
        if (tiemp_seg == 0)
        {
            ecsenario.SetActive(false);
            tiemp_seg = tiempo_reinicio;
        }
        
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
