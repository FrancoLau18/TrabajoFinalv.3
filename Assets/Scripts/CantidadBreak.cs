using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cantidad_Bread : MonoBehaviour
{
    private float breads;
    public Text Cantid_Breads;
    public void Incremen_Breads()
    {
        breads = breads + 1;
        Cantid_Breads.text = ":" + breads;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bread")
        {
            Incremen_Breads();
        }
    }
}
