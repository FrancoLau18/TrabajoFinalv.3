using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Controlador_Ingredientes.instance.Aumento_tomato();
            Destroy(this.gameObject);
        }
    }
}
