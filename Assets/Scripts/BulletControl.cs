using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    private Rigidbody2D _compRigidbody2D;
    public float speed;
    public int xDirection;
    public GameObject Blast;

    private void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Destroy(gameObject, 0.3f);        
    }
    private void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag=="Box")
        {
            Destroy(gameObject);
            Instantiate(Blast, transform.position, transform.rotation);
            
        }
    }
}
