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

    Transform fogata;
    Light luz;
    


    public void Awake()
    {
        fogata=GetComponent<Transform>();
        luz = GetComponent<Light>();
        
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
        SceneManager.LoadScene(CentroEsen);
    }
    public void CambiarEscena_Mexico()
    {
        SceneManager.LoadScene(mexicoEsen);
    }
    public void CambiarEscena_Sur()
    {
        SceneManager.LoadScene(SurEsen);
    }

}

