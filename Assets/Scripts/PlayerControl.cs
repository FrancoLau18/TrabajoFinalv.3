using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerControl : MonoBehaviour 
{
    private float Vida = 100;
    public Transform Controlador_golpe;
    public float horizontal;
    public float vertical;
    public float speedX;
    public float speedY;
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
    }
    void Update()
    {
        if (Vida<=0)
        {
            Destroy(this.gameObject);
        }
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw ("Vertical");
        _compAnimator.SetInteger("isWalking", (int)(horizontal + vertical));
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
        _compRigidbody2D.velocity = new Vector2(speedX * horizontal, speedY * vertical);
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
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Vida = Vida - 10;
            print("Se pudo");
        }
    }
}

