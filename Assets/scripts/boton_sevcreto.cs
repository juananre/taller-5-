using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boton_sevcreto : MonoBehaviour
{
    [SerializeField] private int inicio_real = 0;

    // Update is called once per frame
    public void carga_secreta()
    {
        SceneManager.LoadScene(inicio_real);
    }

}
