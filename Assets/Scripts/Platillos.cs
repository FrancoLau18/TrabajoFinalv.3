using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platillos : MonoBehaviour
{
    public Platillos(float a)
    {
        Controlador_Ingredientes.instance.Cura(1);
    }
    public Platillos(int e)
    {
        Controlador_Ingredientes.instance.Cura(2);
    }
    public Platillos(string i)
    {
        Controlador_Ingredientes.instance.Cura(3);
    }
    public Platillos(float a,int e)
    {
        Controlador_Ingredientes.instance.Cura(4);
    }
    public Platillos(int e, float a)
    {
        Controlador_Ingredientes.instance.Ataque_Extra(1);
    }
    public Platillos(float a, string i)
    {
        Controlador_Ingredientes.instance.Ataque_Extra(2);
    }
    public Platillos(string i, float a)
    {
        Controlador_Ingredientes.instance.Cura(1);
        Controlador_Ingredientes.instance.Ataque_Extra(1);
    }
    public Platillos(int e, string i)
    {
        Controlador_Ingredientes.instance.Cura(3);
        Controlador_Ingredientes.instance.Ataque_Extra(3);
    }
}
