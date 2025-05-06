using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ejercicio : MonoBehaviour {

    public GameObject mensaje;

    public void Error()
    {
        StartCoroutine(ErrorGrafica());
    }
    IEnumerator ErrorGrafica()
    {
        mensaje.SetActive(true);
        yield return new WaitForSeconds(2);
        mensaje.SetActive(false);

    }
 
    public void cambio_escena_1()
    {
        SceneManager.LoadScene("Grafica_1");
    }
    public void cambio_escena_2()
    {
        SceneManager.LoadScene("Grafica_2");
    }

    public void cambio_escena_3()
    {
        SceneManager.LoadScene("Grafica_3");
    }

    public void cambio_escena_4()
    {
        SceneManager.LoadScene("Grafica_4");
    }
    public void cambio_escena_5()
    {
        SceneManager.LoadScene("Grafica_5");
    }
    public void cambio_escena_6()
    {
        SceneManager.LoadScene("Grafica_6");
    }
    public void cambio_escena_7()
    {
        SceneManager.LoadScene("Grafica_7");
    }
    public void cambio_escena_8()
    {
        SceneManager.LoadScene("Grafica_8");
    }
    public void cambio_escena_9()
    {
        SceneManager.LoadScene("Grafica_9");
    }
    public void cambio_escena_10()
    {
        SceneManager.LoadScene("Grafica_10");
    }
    public void cambio_escena_11()
    {
        SceneManager.LoadScene("Grafica_11");
    }
    public void cambio_escena_12()
    {
        SceneManager.LoadScene("Grafica_12");
    }
    public void cambio_escena_13()
    {
        SceneManager.LoadScene("Grafica_13");
    }
    public void cambio_escena_14()
    {
        SceneManager.LoadScene("Grafica_14");
    }
    public void cambio_escena_15()
    {
        SceneManager.LoadScene("Grafica_15");
    }
    public void cambio_escena_16()
    {
        SceneManager.LoadScene("Grafica_16");
    }
    public void cambio_escena_17()
    {
        SceneManager.LoadScene("Grafica_17");
    }
    public void cambio_escena_18()
    {
        SceneManager.LoadScene("Grafica_18");
    }
    public void cambio_escena_19()
    {
        SceneManager.LoadScene("Grafica_19");
    }
    public void cambio_escena_20()
    {
        SceneManager.LoadScene("Grafica_20");
    }
    public void cambio_escena_21()
    {
        SceneManager.LoadScene("Grafica_21");
    }
    public void cambio_escena_22()
    {
        SceneManager.LoadScene("Grafica_22");
    }
    public void cambio_escena_23()
    {
        SceneManager.LoadScene("Grafica_23");
    }
    public void cambio_escena_24()
    {
        SceneManager.LoadScene("Grafica_24");
    }
    public void cambio_escena_25()
    {
        SceneManager.LoadScene("Grafica_25");
    }
    public void cambio_escena_26()
    {
        SceneManager.LoadScene("Grafica_26");
    }
    public void cambio_escena_27()
    {
        SceneManager.LoadScene("Grafica_27");
    }
    public void cambio_escena_28()
    {
        SceneManager.LoadScene("Grafica_28");
    }
    public void cambio_escena_29()
    {
        SceneManager.LoadScene("Grafica_29");
    }
    public void cambio_escena_30()
    {
        SceneManager.LoadScene("Grafica_30");
    }
    public void cambio_escena_menu()
    {
        SceneManager.LoadScene("Menu_usuario");
    }

 
}
