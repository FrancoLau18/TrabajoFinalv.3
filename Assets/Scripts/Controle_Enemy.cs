using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle_Enemy : SeresVivos 
{
    private Rigidbody2D _compRigidBody2D;
    public float speedY;
    private void Awake()
    {
        _compRigidBody2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        _compRigidBody2D.velocity = new Vector2(0, -speedY);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet" || collision.gameObject.tag =="Player")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Suelo" )
        {
            Destroy(this.gameObject, 2.0f);
        }
    }
}
