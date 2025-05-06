using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu_usuario : MonoBehaviour {

    public Dropdown dropdown;
    public Dropdown dropdown2;
    public Dropdown dropdown3;
    public Dropdown dropdown4;
    public Dropdown dropdown5;
    public Dropdown dropdown6;
    public GameObject valorlogin;
    public Text nom;

    List<string> names = new List<string>() { "selecione Funcion", "Lineal 1", "Lineal 2", "Lineal 3", "Lineal 4", "Lineal 5" };
    List<string> names2 = new List<string>() { "selecione Funcion", "Cubicas 1", "Cubicas 2", "Cubicas 3", "Cubicas 4", "Cubicas 5" };
    List<string> names3 = new List<string>() { "selecione Funcion", "Logaritmica 1", "Logaritmica 2", "Logaritmica 3", "Logaritmica 4", "Logaritmica 5" };
    List<string> names4 = new List<string>() { "selecione Funcion", "Cuadratica 1", "Cuadratica 2", "Cuadratica 3", "Cuadratica 4", "Cuadratica 5" };
    List<string> names5 = new List<string>() { "selecione Funcion", "Exponencial 1", "Exponencial 2", "Exponencial 3", "Exponencial 4", "Exponencial 5" };
    List<string> names6 = new List<string>() { "selecione Funcion", "Trigonometrica 1", "Trigonometrica 2", "Trigonometrica 3", "Trigonometrica 4", "Trigonometrica 5" };


    public void Dropdown_indexcambio(int index)
    {

        if (index == 1)
        {
            SceneManager.LoadScene("Ejercicio_1");
        }
        if (index == 2)
        {
            SceneManager.LoadScene("Ejercicio_2");
        }
        if (index == 3)
        {
            SceneManager.LoadScene("Ejercicio_3");
        }
        if (index == 4)
        {
            SceneManager.LoadScene("Ejercicio_4");
        }
        if (index == 5)
        {
            SceneManager.LoadScene("Ejercicio_5");
        }
    }
    public void Dropdown_indexcambio2(int index)
    {
        if (index == 1)
        {
            SceneManager.LoadScene("Ejercicio_6");
        }
        if (index == 2)
        {
            SceneManager.LoadScene("Ejercicio_7");
        }
        if (index == 3)
        {
            SceneManager.LoadScene("Ejercicio_8");
        }
        if (index == 4)
        {
            SceneManager.LoadScene("Ejercicio_9");
        }
        if (index == 5)
        {
            SceneManager.LoadScene("Ejercicio_10");
        }
    }
    public void Dropdown_indexcambio3(int index)
    {
        if (index == 1)
        {
            SceneManager.LoadScene("Ejercicio_11");
        }
        if (index == 2)
        {
            SceneManager.LoadScene("Ejercicio_12");
        }
        if (index == 3)
        {
            SceneManager.LoadScene("Ejercicio_13");
        }
        if (index == 4)
        {
            SceneManager.LoadScene("Ejercicio_14");
        }
        if (index == 5)
        {
            SceneManager.LoadScene("Ejercicio_15");
        }
    }
    public void Dropdown_indexcambio4(int index)
    {
        if (index == 1)
        {
            SceneManager.LoadScene("Ejercicio_16");
        }
        if (index == 2)
        {
            SceneManager.LoadScene("Ejercicio_17");
        }
        if (index == 3)
        {
            SceneManager.LoadScene("Ejercicio_18");
        }
        if (index == 4)
        {
            SceneManager.LoadScene("Ejercicio_19");
        }
        if (index == 5)
        {
            SceneManager.LoadScene("Ejercicio_20");
        }
    }
    public void Dropdown_indexcambio5(int index)
    {
        if (index == 1)
        {
            SceneManager.LoadScene("Ejercicio_21");
        }
        if (index == 2)
        {
            SceneManager.LoadScene("Ejercicio_22");
        }
        if (index == 3)
        {
            SceneManager.LoadScene("Ejercicio_23");
        }
        if (index == 4)
        {
            SceneManager.LoadScene("Ejercicio_24");
        }
        if (index == 5)
        {
            SceneManager.LoadScene("Ejercicio_25");
        }
    }
    public void Dropdown_indexcambio6(int index) {
        if (index == 1)
        {
            SceneManager.LoadScene("Ejercicio_26");
        }
        if (index == 2)
        {
            SceneManager.LoadScene("Ejercicio_27");
        }
        if (index == 3)
        {
            SceneManager.LoadScene("Ejercicio_28");
        }
        if (index == 4)
        {
            SceneManager.LoadScene("Ejercicio_29");
        }
        if (index == 5)
        {
            SceneManager.LoadScene("Ejercicio_30");
        }

    }



    void Start()
    {
        Populatelist();
        Populatelist2();
        Populatelist3();
        Populatelist4();
        Populatelist5();
        Populatelist6();


    }
    void Populatelist()
    {
        dropdown.AddOptions(names);
    }
    void Populatelist2()
    {
        dropdown2.AddOptions(names2);
    }
    void Populatelist3()
    {
        dropdown3.AddOptions(names3);
    }
    void Populatelist4()
    {
        dropdown4.AddOptions(names4);
    }
    void Populatelist5()
    {
        dropdown5.AddOptions(names5);
    }
    void Populatelist6() {

        dropdown6.AddOptions(names6);
    }
    public void cambio_escena()
    {
        SceneManager.LoadScene("Login");
    }
    public void url()
    {
        Application.OpenURL("https://www.udeccal.com/proyecto/");
    }
    
}
