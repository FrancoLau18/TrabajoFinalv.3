using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEnemy3 : MonoBehaviour
{
    private Rigidbody2D _compRigidBody2D;
    public float speedX;
    private void Awake()
    {
        _compRigidBody2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        _compRigidBody2D.velocity = new Vector2(speedX, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
        }
    }
}
