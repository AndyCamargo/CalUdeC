using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Registro_admin : MonoBehaviour {

    public InputField Nombre;
    public InputField Apellido;
    public InputField Cedula;
    public InputField Codudec;
    public InputField Contrasena;
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
        form.AddField("apePost", Apellido.text);
        form.AddField("ceduPost", Cedula.text);
        form.AddField("codPost", Codudec.text);

        // WWW www = new WWW("http://udeccal.com/insertUser2.php", form);
        WWW www = new WWW("http://udeccal.com/insertUser2.php", form);
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
    submitButton.interactable = (Nombre.text.Length >= 4 && Contrasena.text.Length >= 4  && Apellido.text.Length >= 5 && Cedula.text.Length >= 7 && Codudec.text.Length >= 7 );
    }
    public void salir_camara()
    {
        SceneManager.LoadScene("Menu_admin");
    }


}
