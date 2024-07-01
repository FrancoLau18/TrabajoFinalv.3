using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador_Ingredientes  : MonoBehaviour
{
    public int cura;
    public int ataque_extra;
    public static Controlador_Ingredientes instance;
    public float Tomato;
    public float Chicken;
    public float Bread;
    private void Awake()
    {
        if (Controlador_Ingredientes.instance==null) 
        {
            Controlador_Ingredientes.instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void Aumento_tomato()
    {
        Tomato++;
    }
    public void Aumento_bread()
    {
        Bread++;
    }
    public void Aumento_Chicken()
    {
        Chicken++;
    }
    public void Cura(int cura)
    {
        this.cura = this.cura + cura;
    }
    public void Ataque_Extra(int ataque_extra)
    {
        this.ataque_extra = this.ataque_extra + ataque_extra;
    }
}
