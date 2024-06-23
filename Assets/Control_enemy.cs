using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_enemy : MonoBehaviour
{
    private float Vida=100;
    public float Speed;
    public GameObject objective;
    public ChasingAreaEnmyControl chasingAreaEnmy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vida <= 0)
        {
            Destroy(this.gameObject);
        }
        if (chasingAreaEnmy.isChasingPlayer == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, objective.transform.position, Speed * Time.deltaTime);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Bullet(Clone)")
        {
            Vida = Vida - 10;
        }
    }
}
