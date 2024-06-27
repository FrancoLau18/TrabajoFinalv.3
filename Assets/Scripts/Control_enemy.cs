using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_enemy : SeresVivos
{ 
    public float Speed;
    public GameObject objective;
    public ChasingAreaEnmyControl chasingAreaEnmy;

    // Start is called before the first frame update
    void Awake()
    {
        Life = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Verificate_Life();
        if (chasingAreaEnmy.isChasingPlayer == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, objective.transform.position, Speed * Time.deltaTime);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Bullet(Clone)")
        {
            Life = Life - 10;
        }
    }
}
