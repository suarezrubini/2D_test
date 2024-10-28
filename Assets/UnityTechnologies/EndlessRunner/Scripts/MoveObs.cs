using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObs : MonoBehaviour
{
    [SerializeField] float PosX;
    public float speed;

    void Update()
    {

    Vector3 despl = new Vector3(PosX, 0, 0);
    transform.Translate(despl* Time.deltaTime* speed);

}
}
