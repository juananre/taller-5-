using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class boton_inicio : MonoBehaviour
{
    [SerializeField] private int inicio;
    [SerializeField] private float tiempo_fate =2f;

    private Animator fade;

    void Start()
    {
        fade = GetComponentInChildren<Animator>();
    }

    public void inicio_inicio()
    {
        StartCoroutine(fade_inicio(inicio));
    }

    public IEnumerator fade_inicio(int inicio)
    {
        fade.SetTrigger("fade out");
        yield return new WaitForSeconds(tiempo_fate);
        SceneManager.LoadScene(inicio);
    }
}
