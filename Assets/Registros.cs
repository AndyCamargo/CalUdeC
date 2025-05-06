using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Registros : MonoBehaviour {

    public InputField Nombre;
    public InputField Apellido;
    public InputField Cedula;
    public InputField Codudec;
    public InputField Telefono;
    public InputField Contrasena;
    public InputField Email;

    public Button submitButton;
    public void CallRegister()
    {
        StartCoroutine(Register());
    }
    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", Nombre.text);
        form.AddField("passPost", Contrasena.text);
        form.AddField("emailPost", Email.text);
        form.AddField("apePost", Apellido.text);
        form.AddField("ceduPost", Cedula.text);
        form.AddField("codPost", Codudec.text);
        form.AddField("telePost", Telefono.text);
       // WWW www = new WWW("http://caludec.eshost.com.ar/insertUser.php", form);
        WWW www = new WWW("http://udeccal.com/insertUser.php", form);
        yield return www;
        if (www.text == "0")
        {
            Debug.Log("ususario creado correctamente");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        else
        {
            Debug.Log("ususario no creado erro" + www.text);
        }
    }

    public void verificarInputs()
    {
        submitButton.interactable = (Nombre.text.Length >= 3 && Contrasena.text.Length >= 4 && Email.text.Length >= 7 && Apellido.text.Length >= 5 && Cedula.text.Length >= 7 && Codudec.text.Length >= 8 && Telefono.text.Length >= 7);
    }
    public void salir_camara()
    {
        SceneManager.LoadScene("Login");
    }
    public void Ayuda()
    {
        SceneManager.LoadScene("Ayuda2");
    }
}
