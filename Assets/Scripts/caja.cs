using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caja : MonoBehaviour
{
    public Transform fruit1;
    public Transform fruit2;
    public GameObject fruta1;
    public GameObject fruta2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name =="Bullet(Clone)" )
        {
            Instantiate(fruta1, fruit1.position, fruit1.rotation);
            Instantiate(fruta2, fruit2.position, fruit2.rotation);
            Destroy(this.gameObject);
        }
    }
}
