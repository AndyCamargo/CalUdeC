using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lista_Funciones : MonoBehaviour {

    public Text tablita; 
	// Use this for initialization
	IEnumerator Start () {

        WWW www = new WWW("http://udeccal.com/listafunciones.php");
        yield return www;
        string itemsDataString = www.text;
        print(itemsDataString);
        tablita.text=itemsDataString;
    }
  
    // Update is called once per frame
    void Update () {
		
	}
    public void Volver()
    {
        SceneManager.LoadScene("Menu_admin");
    }
}
