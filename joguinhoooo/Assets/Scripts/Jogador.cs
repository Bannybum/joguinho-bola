using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float JumpForce;
    public float Speed;

    public bool isJumping;
    public bool DoubleJumping;

    private Rigidbody2D rig;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        float moveInput = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveInput, 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;

        if (moveInput > 0f)
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        else if (moveInput < 0f)
        {
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (!isJumping)
            {
                rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                isJumping = true;
            }
            else if (!DoubleJumping)
            {
                rig.velocity = new Vector2(rig.velocity.x, 0f);
                rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                DoubleJumping = true;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
            DoubleJumping = false;
        }
    }
}
