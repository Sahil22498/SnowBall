using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5f;
    public float Jump = 3;

    private Rigidbody2D mybody;
    private Animator anim;

    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;
    public KeyCode throwball;

    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask Ground;

    public bool isGrounded;

    public GameObject snowBall;
    public Transform throwPoint;

    public AudioSource throwSound;


    void Start()
    {
        mybody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, Ground);


        if (Input.GetKey(left))
            {
            mybody.velocity = new Vector2(-Speed, mybody.velocity.y);
        } else if (Input.GetKey(right)){
            mybody.velocity = new Vector2(Speed, mybody.velocity.y);
        }
        else
        {
            mybody.velocity = new Vector2(0, mybody.velocity.y);
        }


        if (Input.GetKeyDown(jump) &&  isGrounded)
        {
            mybody.velocity = new Vector2(mybody.velocity.x, Jump);
        }

        if (Input.GetKeyDown(throwball))
        {
            GameObject ballClone = (GameObject)Instantiate(snowBall, throwPoint.position, throwPoint.rotation);
            ballClone.transform.localScale = transform.localScale;

            anim.SetTrigger("Throw");

            throwSound.Play();
        }

        if (mybody.velocity.x <0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }else if(mybody.velocity.x >0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        anim.SetFloat("Speed", Mathf.Abs(mybody.velocity.x));
        anim.SetBool("Grounded", isGrounded);

    }
}   // class
