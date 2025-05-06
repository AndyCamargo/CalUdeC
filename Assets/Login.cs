using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Login : MonoBehaviour {

    public GameObject mensaje;
    public InputField Usuario;
    public InputField Clave;
    public Button submitButton;


    public void CallLogin()
    {
        StartCoroutine(login());
    }
    IEnumerator login()
    {
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", Usuario.text);
        form.AddField("passPost", Clave.text);
        WWW www = new WWW("http://udeccal.com/login.php", form);
       // WWW www = new WWW("http://caludec.eshost.com.ar/login.php", form);
        yield return www;
        if (www.text == "0")
        {
            mensaje.SetActive(true);
            print(Time.time);
            yield return new WaitForSeconds(5);
            SceneManager.LoadScene("Login");
            Debug.Log("no se logeo bien " + www.text);
            
        }
        else {
            //si no evalua que es usuario o administrador
            if (www.text == "1")
            {
                 Debug.Log("se logio bien  " + www.text);
                SceneManager.LoadScene("Menu_admin");
            }
            if (www.text == "2")
            {
                Debug.Log("se logio bien  " + www.text);
                SceneManager.LoadScene("Menu_usuario");

            }

        }



    }
   

    public void verificarInputs()
    {
        submitButton.interactable = (Usuario.text.Length >= 6 && Clave.text.Length >= 3 );
    }

    public void registro() {
        SceneManager.LoadScene("Registro_usuario");
    }
    public void salir_camara()
    {
        Application.Quit();
    }
   
    public void Ayuda()
    {
        SceneManager.LoadScene("Ayuda");
    }

 
   
}
