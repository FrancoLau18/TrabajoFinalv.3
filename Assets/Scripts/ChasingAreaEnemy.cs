using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasingAreaEnmyControl : MonoBehaviour
{
    public bool isChasingPlayer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isChasingPlayer = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isChasingPlayer = false;
        }
    }
}