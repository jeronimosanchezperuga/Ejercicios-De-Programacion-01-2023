using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NombreYEdad : MonoBehaviour
{
    public TextMeshProUGUI txtTextoEnPantalla;
    public string nomrbreUsuario;
    public int edadUsuario;

    // Start is called before the first frame update
    void Start()
    {
        //�Me llamo <valor de la variable string> y tengo <valor de la variable int> a�os�
        string mensaje = "Me llamo " + nomrbreUsuario + " y tengo " + edadUsuario + " a�os." ;
        txtTextoEnPantalla.text = mensaje;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
