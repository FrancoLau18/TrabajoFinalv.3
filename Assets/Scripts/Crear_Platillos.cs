using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crear_Platillos : MonoBehaviour
{
    float a;
    int e;
    string i;
    public void Platillo(int tipe_platillo)
    {
        switch (tipe_platillo)
        {
            case 1:
                if (Controlador_Ingredientes.instance.Tomato >= 1&& Controlador_Ingredientes.instance.Chicken >= 1)
                {
                    Platillos platillo1 = new Platillos(a);
                    Controlador_Ingredientes.instance.Tomato = Controlador_Ingredientes.instance.Tomato - 1;
                    Controlador_Ingredientes.instance.Chicken = Controlador_Ingredientes.instance.Chicken - 1;
                }
                break;
            case 2:
                if (Controlador_Ingredientes.instance.Tomato >= 2 && Controlador_Ingredientes.instance.Bread >= 1 && Controlador_Ingredientes.instance.Chicken >= 1)
                {
                    Platillos platillo2 = new Platillos(e);
                    Controlador_Ingredientes.instance.Tomato = Controlador_Ingredientes.instance.Tomato - 2;
                    Controlador_Ingredientes.instance.Bread  = Controlador_Ingredientes.instance.Bread - 1;
                    Controlador_Ingredientes.instance.Chicken = Controlador_Ingredientes.instance.Chicken - 1;
                }
                break;
            case 3:
                if (Controlador_Ingredientes.instance.Tomato >= 2 && Controlador_Ingredientes.instance.Bread >= 1 && Controlador_Ingredientes.instance.Chicken >= 3)
                {
                    Platillos platillo3 = new Platillos(i);
                    Controlador_Ingredientes.instance.Tomato = Controlador_Ingredientes.instance.Tomato - 2;
                    Controlador_Ingredientes.instance.Bread  = Controlador_Ingredientes.instance.Bread - 1;
                    Controlador_Ingredientes.instance.Chicken = Controlador_Ingredientes.instance.Chicken - 3;
                }
                break;
            case 4:
                if (Controlador_Ingredientes.instance.Tomato >= 3 && Controlador_Ingredientes.instance.Bread >= 2 && Controlador_Ingredientes.instance.Chicken >= 4)
                {
                    Platillos platillo4 = new Platillos(a,e);
                    Controlador_Ingredientes.instance.Tomato = Controlador_Ingredientes.instance.Tomato - 3;
                    Controlador_Ingredientes.instance.Bread = Controlador_Ingredientes.instance.Bread - 2;
                    Controlador_Ingredientes.instance.Chicken = Controlador_Ingredientes.instance.Chicken - 4;
                }
                break;
            case 5:
                if (Controlador_Ingredientes.instance.Tomato >= 2 && Controlador_Ingredientes.instance.Bread >= 1)
                {
                    Platillos platillo5 = new Platillos(e,a);
                    Controlador_Ingredientes.instance.Tomato = Controlador_Ingredientes.instance.Tomato - 2;
                    Controlador_Ingredientes.instance.Bread = Controlador_Ingredientes.instance.Bread - 1;;
                }
                break;
            case 6:
                if (Controlador_Ingredientes.instance.Tomato >= 2 && Controlador_Ingredientes.instance.Bread >= 3 && Controlador_Ingredientes.instance.Chicken >= 2)
                {
                    Platillos platillo6 = new Platillos(a,i);
                    Controlador_Ingredientes.instance.Tomato = Controlador_Ingredientes.instance.Tomato - 2;
                    Controlador_Ingredientes.instance.Bread = Controlador_Ingredientes.instance.Bread - 3;
                    Controlador_Ingredientes.instance.Chicken = Controlador_Ingredientes.instance.Chicken - 2;
                }
                break;
            case 7:
                if (Controlador_Ingredientes.instance.Tomato >= 3 && Controlador_Ingredientes.instance.Bread >= 1)
                {
                    Platillos platillo1 = new Platillos(i,a);
                    Controlador_Ingredientes.instance.Tomato = Controlador_Ingredientes.instance.Tomato - 3;
                    Controlador_Ingredientes.instance.Bread = Controlador_Ingredientes.instance.Bread - 1;
                }
                break;
            case 8:
                if (Controlador_Ingredientes.instance.Tomato >= 4 && Controlador_Ingredientes.instance.Bread >= 4 && Controlador_Ingredientes.instance.Chicken >= 4)
                {
                    Platillos platillo1 = new Platillos(e,i);
                    Controlador_Ingredientes.instance.Tomato = Controlador_Ingredientes.instance.Tomato - 4;
                    Controlador_Ingredientes.instance.Bread = Controlador_Ingredientes.instance.Bread - 4;
                    Controlador_Ingredientes.instance.Chicken = Controlador_Ingredientes.instance.Chicken - 4;
                }
                break;
        }
    }
}
