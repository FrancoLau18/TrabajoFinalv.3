using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cantidad_Chicken : MonoBehaviour
{
    private float chicken;
    public Text Cantid_Chicken;
    public void Incremen_Chicken()
    {
        chicken = chicken + 1;
        Cantid_Chicken.text = ":" + chicken;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Chicken")
        {
            Incremen_Chicken();
        }
    }
}