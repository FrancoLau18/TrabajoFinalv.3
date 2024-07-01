using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MochilaPan : MonoBehaviour
{
    public Text textPan;  
    void Start()
    {
        textPan.text = "" + Controlador_Ingredientes.instance.Bread; 
    }
    void Update()
    {
        textPan.text = "" + Controlador_Ingredientes.instance.Bread;
    }
}
