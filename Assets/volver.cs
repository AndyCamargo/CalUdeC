using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class volver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void salir_camara()
    {
        SceneManager.LoadScene("Menu_usuario");
    }

    public void salir_login()
    {
        SceneManager.LoadScene("Login");
    }
    public void salir_registro()
    {
        SceneManager.LoadScene("Registro_usuario");
    }
}
