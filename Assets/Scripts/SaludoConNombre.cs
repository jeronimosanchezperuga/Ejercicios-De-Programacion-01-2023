using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaludoConNombre : MonoBehaviour
{
    public TextMeshProUGUI txtTextoEnPantalla;
    public string saludo;
    public string nombreUsuario;

    // Start is called before the first frame update
    void Start()
    {
        txtTextoEnPantalla.text = saludo + ", " +  nombreUsuario;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
