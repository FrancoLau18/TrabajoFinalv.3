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
<<<<<<< HEAD
    public GameObject fruta3;
=======
<<<<<<< HEAD
  
=======
>>>>>>> 0d61ace403eb39f4413fffdef0de15328560daef
>>>>>>> 3dc0c6e683fd944d8f0072ab2a6ba443434baf4d
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name =="Bullet(Clone)" || collision.gameObject.tag == "Enemy")
        {
<<<<<<< HEAD
            Instantiate(fruta1, fruit1.position, fruit1.rotation);
            Instantiate(fruta2, fruit2.position, fruit2.rotation);
            Instantiate(fruta3, fruit3.position, fruit3.rotation);
=======
            GameObject pan=Instantiate(fruta1, fruit1.position, fruit1.rotation);
            GameObject tomato=Instantiate(fruta2, fruit2.position, fruit2.rotation);
>>>>>>> 3dc0c6e683fd944d8f0072ab2a6ba443434baf4d
            Destroy(this.gameObject);
        }
      
    }
}
