using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsGrounded : MonoBehaviour
{
    [SerializeField] private LayerMask whatIsGround;
    [SerializeField] float jump = 100f;
    private Rigidbody2D rb;
    private bool isGrounded; 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }
    void Update()
    {
        GroundCheck(); 
        
        if (Input.GetMouseButtonDown(0) && isGrounded)
        {
            Jump(); 
        } 
    }

    private void Jump()
    {
        rb.AddForce(jump * Vector2.up); 
    }

    private void GroundCheck()
    {
        float rayLength = 0.9f;
        Ray ray = new Ray(transform.position, Vector2.down);
        Debug.DrawRay(ray.origin, ray.direction * rayLength, Color.red);

        isGrounded = Physics2D.Raycast(ray.origin, ray.direction, rayLength, whatIsGround); 
    }
}
