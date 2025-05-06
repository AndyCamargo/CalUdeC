using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_admin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void salir_camara()
    {
        SceneManager.LoadScene("Login");
    }

    public void Registro_admin()
    {
        SceneManager.LoadScene("Registro_admin");
    }
    public void Lista_funciones()
    {
        SceneManager.LoadScene("Lista_Funciones");
    }
    public void Lista_usuario_act()
    {
        SceneManager.LoadScene("usuario");
    }
    public void url()
    {
        Application.OpenURL("https://www.udeccal.com/proyecto/");
    }
}
