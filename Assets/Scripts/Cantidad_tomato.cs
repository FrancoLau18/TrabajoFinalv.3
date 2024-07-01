using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cantidad_tomato : MonoBehaviour
{
    private float tomatos;
    public Text Cantid_Tomatos;
    // Update is called once per frame
    void Start()
    {
    }
    public void Incremen_tomato()
    {
        tomatos = tomatos+1;
        Cantid_Tomatos.text = ":" + tomatos;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Tomato(Clone)")
        {
            Incremen_tomato();
        }
    }
}
