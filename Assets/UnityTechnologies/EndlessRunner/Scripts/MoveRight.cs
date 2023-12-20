using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    [SerializeField] float playerSpeed;
    [SerializeField] float jumpForce; 

    private Vector2 playerDirection; 
    private Rigidbody2D rb;
    private bool isGrounded;
    private float Horizontal; 

    void Start()
    {
        // Tenemos que afectar al Rigidbody 2D 
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        rb.velocity = new Vector2 (playerSpeed,rb.velocity.y);

        //Horizontal = Input.GetAxisRaw("Horizontal");

        float vert = Input.GetAxis("Vertical"); 

        //if (Input.GetKeyDown(KeyCode.W))
        if (vert > 0 && isGrounded)
        {
            Jump();
        }

        float directionX = Input.GetAxisRaw("Horizontal"); 
        playerDirection = new Vector2(0, directionX).normalized;
    }
    private void Jump()
    {
        //rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        rb.AddForce(Vector2.up * jumpForce); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Suelo")
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            isGrounded = false; 
        }

        /* Para RAYCAST

        float alcance = 100f;

        Vector3 origen = transform.position;

        RaycastHit2D hit = Physics2D.Raycast(origen, Vector2.down, alcance);
        Debug.DrawRay(origen, Vector2.down, Color.cyan, alcance);

        if (hit.collider != null)
        {
            isGrounded = true;
        } */ 
    }
}
