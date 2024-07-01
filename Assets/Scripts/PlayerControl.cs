using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : SeresVivos 
<<<<<<< HEAD
{ 
=======
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
>>>>>>> 0d61ace403eb39f4413fffdef0de15328560daef
    public Transform Controlador_golpe;
    public float horizontal;
    public float vertical;
    public float Speed;
    private Rigidbody2D _compRigidbody2D;
    public GameObject bulletPrefab;
    public AudioSource _compAudioSource;
    private Animator _compAnimator;
    private bool vista_horizontal;
    public GameManagerControl gameManager;
    private void Awake(){
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        _compAnimator = GetComponent<Animator>();
        Life = 10 + Controlador_Ingredientes.instance.cura;
        Attack = 1 + Controlador_Ingredientes.instance.ataque_extra;
    }
    void Update()
    {
        Mover();
        Verificate_Life();
        horizontal = Input.GetAxisRaw("Horizontal");
<<<<<<< HEAD
        _compAnimator.SetInteger("isWalking", (int)(horizontal ));
        Puching();            
=======
<<<<<<< HEAD
       // vertical = Input.GetAxisRaw ("Vertical");
        _compAnimator.SetInteger("isWalking", (int)(horizontal + vertical));
=======
        vertical = Input.GetAxisRaw ("Vertical");
>>>>>>> 0d61ace403eb39f4413fffdef0de15328560daef
        Puching();
        /*Flip();*/          
>>>>>>> 3dc0c6e683fd944d8f0072ab2a6ba443434baf4d
    }
    void Puching()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            _compAnimator.SetBool("isPunching", true);
            if (_compAnimator.GetBool("isPunching") )
            {
                Instantiate(bulletPrefab, Controlador_golpe.position, Controlador_golpe.rotation);
                _compAudioSource.Play();
            }
          
        }
        else if (Input.GetButtonUp("Fire1") )
        {          
            _compAnimator.SetBool("isPunching", false);
        }
    }
    private void FixedUpdate()
    {
<<<<<<< HEAD
        _compRigidbody2D.velocity = new Vector2(speedX * horizontal, 0);
=======
        _compRigidbody2D.velocity = new Vector2(Speed * horizontal, Speed * vertical);
>>>>>>> 0d61ace403eb39f4413fffdef0de15328560daef
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Life = Life - 1;
            gameManager.DecreaseLife(Life);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Life = Life - 1;
            gameManager.DecreaseLife(Life);
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
    protected void Verificate_Life()
    {
        if (Life <= 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("Perder");
        }
    }
}

