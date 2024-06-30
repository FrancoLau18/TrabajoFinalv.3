using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerControl : SeresVivos 
{
<<<<<<< HEAD
    public bool golpeando;
=======
<<<<<<< HEAD
    
=======
<<<<<<< HEAD
    private float Vida = 100;
=======
>>>>>>> 3c451c0e41280240c61b41f3cd9f3bf86cc1818c
>>>>>>> cc3b3966744e5ecd26bb32544ebc5818448637aa
>>>>>>> f5f6dc178f3b0e409fd31963c298333a96a73da3
    public Transform Controlador_golpe;
    public float horizontal;
    public float vertical;
    public float Speed;
    private Rigidbody2D _compRigidbody2D;
    public GameObject bulletPrefab;
   // public AudioSource _compAudioSource;
    private Animator _compAnimator;
    private SpriteRenderer _compSpriteRenderer;
    private bool vista_horizontal;
    private void Awake(){
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        _compAnimator = GetComponent<Animator>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
        Life = 100;
        Attack = 10;
    }
    void Update()
    {
        Mover();
        Verificate_Life();
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw ("Vertical");
        Puching();
        /*Flip();*/          
    }
    void Puching()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            _compAnimator.SetBool("isPunching", true);
            if (_compAnimator.GetBool("isPunching") )
            {
                Instantiate(bulletPrefab, Controlador_golpe.position, Controlador_golpe.rotation);
            }
 
            // _compAudioSource.Play();
        }
        else if (Input.GetButtonUp("Fire1") )
        {          
            _compAnimator.SetBool("isPunching", false);
        }
    }
    /*void Flip()
    {
        if (horizontal < 0)
        {
            _compSpriteRenderer.flipX = true;
            
        }
        else if (horizontal > 0)
        {
            _compSpriteRenderer.flipX = false;
        }
    }*/
    private void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(Speed * horizontal, Speed * vertical);
        if(horizontal<0 && !vista_horizontal)
        {
            Girar();
        }
        if(horizontal>0 && vista_horizontal)
        {
            Girar();
        }
    }
    private void Girar()
    {
        vista_horizontal = !vista_horizontal;
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
<<<<<<< HEAD
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Life = Life - 10;
            print("Se pudo");
        }
=======
>>>>>>> 3c451c0e41280240c61b41f3cd9f3bf86cc1818c
    }
    private void Mover()
    {
        if ((horizontal < 0 || horizontal > 0) && !golpeando)
        {
            _compAnimator.SetInteger("isWalking", (int)(horizontal + vertical));
        }
        else
        {
            _compAnimator.SetBool("Idle", true);
        }
        if (horizontal == 0 && !golpeando)
        {
            _compAnimator.SetBool("Idle", true);
        }
    }
    private void Fin_Ani()
    {
        golpeando = false;
    }
}

