using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villain : MonoBehaviour
{
    public Animator animator;
    private Rigidbody2D rb;
    private bool isFalling = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter2D (Collision2D collision)
    {
        if (!isFalling && collision.gameObject.CompareTag("Player"))
        {
            TriggerFall();
        }
    }

    private void TriggerFall()
    {
        isFalling = true;
        rb.gravityScale = 2;
        animator.SetTrigger("IsFalling");

    }

}
