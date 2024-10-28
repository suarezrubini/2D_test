using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    //MOVIMIENTO Y SALTO 
    [SerializeField] float playerSpeed;
    [SerializeField] float jumpForce; 

    //private Vector2 playerDirection; 
    private Rigidbody2D rb;
    //private float Horizontal;

    //SUELO CHECK  
    private bool isGrounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer; 


    void Start()
    {
        // Tenemos que afectar al Rigidbody 2D 
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        //MOVIMIENTO HACIA DELANTE 
        rb.linearVelocity = new Vector2 (playerSpeed,rb.linearVelocity.y);

        //float directionX = Input.GetAxisRaw("Horizontal");
        //playerDirection = new Vector2(directionX, 0).normalized;

        //SUELO (true o false)
        
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        //SALTO 

        //SALTO CON ESPACIO 
        //if (Input.GetKey(KeyCode.Space))

        float vert = Input.GetAxis("Vertical");

        if (vert > 0 && isGrounded == true)
        {
           Jump();
           isGrounded = false;
        }
    }
    private void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce);
        
    }
   
    /*private void OnCollisionEnter2D(Collision2D collision)
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
    */
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
