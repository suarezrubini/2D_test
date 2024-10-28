using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    //GROUND DETECTION
    private bool canJump; 
    //lo que choca de nuestro personaje 
    [SerializeField] Transform foot;
    [SerializeField]
    //donde vamos a chocar 
    private LayerMask groundMask; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space) && CheckGrounding())
        {
            canJump = true; 
        }
    }
    
    //metodo booleano, true o false 
    private bool CheckGrounding()
    {
        RaycastHit2D hit;
        hit = Physics2D.Raycast(foot.position, Vector2.down, 1f, groundMask);

        Debug.DrawRay(foot.position, Vector2.down * 1f, Color.red);

        return hit; 
    }
}
