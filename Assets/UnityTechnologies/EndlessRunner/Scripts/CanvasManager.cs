using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class CanvasManager : MonoBehaviour
{
    [SerializeField] Image vidasImage;
    [SerializeField] Sprite[] vidasSprite;
    [SerializeField] int lives;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        vidasImage.sprite = vidasSprite[0];
    }
}
