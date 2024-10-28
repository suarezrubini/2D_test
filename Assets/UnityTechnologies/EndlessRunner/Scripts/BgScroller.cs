using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScroller : MonoBehaviour
{
    public float bgspeed = 4f;
    private Vector3 startPos; 
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * bgspeed * Time.deltaTime);
        if (transform.position.x < -15f)
        {
            transform.position = startPos; 
        }
    }
}
