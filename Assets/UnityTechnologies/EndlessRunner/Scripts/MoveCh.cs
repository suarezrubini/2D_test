using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCh : MonoBehaviour
{
    [SerializeField] Animator anim; 
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //AL PULSAR W HACEMOS QUE SALTE GRACIAS A CONFIGURAR ANTES EL PARÁMETRO 
        float saltar = Input.GetAxis("Vertical"); 
        if (saltar > 0)
        {
            anim.SetTrigger("Saltar");
        }
        //AL PULSAR MOUSE IZQ EL SUELO ES GROUNDED 
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("IsGrounded", true); 
        }
        if (Input.GetMouseButtonDown(1))
        {
            anim.SetBool("IsGrounded", false); 
        }
    }
}
