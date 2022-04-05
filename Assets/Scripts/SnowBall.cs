using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall : MonoBehaviour
{

    public float ballSpeed;
    private Rigidbody2D mybody;
    public GameObject snowBallEffect;

    // Start is called before the first frame update
    void Start()
    {
        mybody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mybody.velocity = new Vector2(ballSpeed * transform.localScale.x, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Player Fire 
        if(other.tag == "Player1")
        {
            FindObjectOfType<Game>().HurtP1();
           // Debug.Log("Fireeeee");
        }
        if (other.tag == "Player2")
        {
            FindObjectOfType<Game>().HurtP2();
          //  Debug.Log("Fireeeeeeeeeeeeeeeeee2");
        }

        Instantiate(snowBallEffect, transform.position, transform.rotation);
        Destroy(gameObject);

    }

    } // class
