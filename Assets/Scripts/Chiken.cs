using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
<<<<<<< HEAD:Assets/Scripts/Chiken.cs
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Controlador_Ingredientes.instance.Aumento_Chicken();
            Destroy(this.gameObject);
        }
    }
}
=======

}
>>>>>>> 0d61ace403eb39f4413fffdef0de15328560daef:Assets/Scripts/Ingredientes.cs
