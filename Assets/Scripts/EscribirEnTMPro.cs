using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EscribirEnTMPro : MonoBehaviour
{
    public TextMeshProUGUI txtTextoEnPantalla;

    // Start is called before the first frame update
    void Start()
    {
        txtTextoEnPantalla.text = "Escribimos desde el script";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
