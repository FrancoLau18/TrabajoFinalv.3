using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caja : MonoBehaviour
{
    public Transform fruit1;
    public Transform fruit2;
    public Transform fruit3;
    public GameObject fruta1;
    public GameObject fruta2;
    public GameObject fruta3;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name =="Bullet(Clone)" || collision.gameObject.tag == "Enemy")
        {
            Instantiate(fruta1, fruit1.position, fruit1.rotation);
            Instantiate(fruta2, fruit2.position, fruit2.rotation);
            Instantiate(fruta3, fruit3.position, fruit3.rotation);
            Destroy(this.gameObject);
        }
      
    }
}
