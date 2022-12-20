using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1;
    public float jumpForce = 1;
    private bool isGround;
    private Rigidbody2D rigidbody2D;
    




    private void FixedUpdate()
    {
        transform.position += new Vector3(speed, 0, 0) * Input.GetAxis("Horizontal");

        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.localScale = new Vector3 (1, 1, 1);
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            isGround = false;
            Jump();
        }
    }

    private void Jump()
    {
        rigidbody2D.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }
}
