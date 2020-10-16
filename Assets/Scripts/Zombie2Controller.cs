using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie2Controller : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sr;
    Animator animator;
    public float velocidad = 4;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velocidad, rb.velocity.y);
        sr.flipX = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            animator.SetBool("EstaAtacando", true);
        }
        else
        {
            animator.SetBool("EstaAtacando", false);
        }

    }
}
