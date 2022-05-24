using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HiervaColision : MonoBehaviour
{
    
    public int mexicoEsen;
    public int CentroEsen;
    public int SurEsen;
    public float tem = 1f;

    private Animator fade;
    Transform fogata;
    Light luz;
    


    public void Awake()
    {
        fogata=GetComponent<Transform>();
        luz = GetComponent<Light>();
        fade = GetComponentInChildren<Animator>();

    }
   

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="mexico")
        {
            
            Invoke(nameof(CambiarEscena_Mexico), tem);
            luz.enabled = true;

        }

        if (collision.gameObject.tag == "Centro")
        {
            Invoke(nameof(CambiarEscena_Centro), tem);
            luz.enabled = true;
            

        }

        if (collision.gameObject.tag == "Sur")
        {
            Invoke(nameof(CambiarEscena_Sur), tem);
            luz.enabled = true;
            

        }
    }
   

    public void CambiarEscena_Centro()
    {
        StartCoroutine(fade_centro(CentroEsen));
    }
    public void CambiarEscena_Mexico()
    {
        StartCoroutine(fade_mex(mexicoEsen));
    }
    public void CambiarEscena_Sur()
    {
        StartCoroutine(fade_sur(SurEsen));
    }

    public IEnumerator fade_centro(int CentroEsen)
    {
        fade.SetTrigger("fade out");
        yield return new WaitForSeconds(tem);
        SceneManager.LoadScene(CentroEsen);
    }
    public IEnumerator fade_sur(int SurEsen)
    {
        fade.SetTrigger("fade out");
        yield return new WaitForSeconds(tem);
        SceneManager.LoadScene(SurEsen);
    }
    public IEnumerator fade_mex(int mexicoEsen)
    {
        fade.SetTrigger("fade out");
        yield return new WaitForSeconds(tem);
        SceneManager.LoadScene(mexicoEsen);
    }
}

