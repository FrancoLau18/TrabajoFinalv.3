using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_enemy : SeresVivos
{ 
    public float Speed;
    public GameObject objective;


    void Awake()
    {
        Life = 100;
    }
    void Update()
    {
        Verificate_Life();      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Bullet(Clone)")
        {
            Life = Life - 10;
        }
    }
}
