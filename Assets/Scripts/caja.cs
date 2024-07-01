using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caja : MonoBehaviour
{
    public Transform fruit1;
    public Transform fruit2;
    public GameObject fruta1;
    public GameObject fruta2;
<<<<<<< HEAD
  
=======
>>>>>>> 0d61ace403eb39f4413fffdef0de15328560daef
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name =="Bullet(Clone)" || collision.gameObject.tag == "Enemy")
        {
            GameObject pan=Instantiate(fruta1, fruit1.position, fruit1.rotation);
            GameObject tomato=Instantiate(fruta2, fruit2.position, fruit2.rotation);
            Destroy(this.gameObject);
        }
      
    }
}
