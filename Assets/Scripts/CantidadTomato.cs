using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cantidad_tomato : MonoBehaviour
{
    private float tomatos;
    public Text Cantid_Tomatos;
    public void Incremen_tomato()
    {
        tomatos = tomatos + 1;
        Cantid_Tomatos.text = ":" + tomatos;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tomato")
        {
            Incremen_tomato();
        }
    }
}