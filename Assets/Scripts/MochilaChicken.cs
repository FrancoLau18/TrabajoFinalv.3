using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MochilaChicken : MonoBehaviour
{
    public Text textChicken;
    void Start()
    {
        textChicken.text = "" + Controlador_Ingredientes.instance.Chicken;
    }
    void Update()
    {
        textChicken.text = "" + Controlador_Ingredientes.instance.Chicken;
    }
}
