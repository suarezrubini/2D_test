using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform personaje;
    private NavMeshAgent agente;

    //PATRULLAJE
    public Transform[] puntosRuta; 
    private int indiceRuta; 
    
    void Awake()
    {
        agente = GetComponent<NavMeshAgent>(); 
    }
    private void Start()
    {
        agente.updateRotation = false; 
        agente.updateUpAxis = false;
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        if (this.transform.position == puntosRuta[indiceRuta].position)
        {
            if(indiceRuta < puntosRuta.Length - 1)
            {
                indiceRuta++;
            }
            else if (indiceRuta == puntosRuta.Length -1)
            {
                indiceRuta = 0; 
            }
        }
        agente.SetDestination(puntosRuta[indiceRuta].position);
    }
}
