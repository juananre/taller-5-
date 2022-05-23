using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class boton_inicio : MonoBehaviour
{
    [SerializeField] private int inicio;

    public void inicio_inicio()
    {
        SceneManager.LoadScene(inicio);
    }
}
