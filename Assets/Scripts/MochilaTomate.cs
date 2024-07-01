using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MochilaTomate : MonoBehaviour
{
    public Text textTomate;
    void Start()
    {
        textTomate.text = "" + Controlador_Ingredientes.instance.Tomato;
    }
    void Update()
    {
        textTomate.text = "" + Controlador_Ingredientes.instance.Tomato;
    }
}
