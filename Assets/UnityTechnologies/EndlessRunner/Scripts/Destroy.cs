using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] SpriteRenderer myMesh;

    private void Start()
    {
        
    }
    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "Obs")
        {
            //Destroy(this.gameObject);
            myMesh.enabled = false;
        }

    }
}
