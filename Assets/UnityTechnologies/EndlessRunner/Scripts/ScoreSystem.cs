using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class ScoreSystem : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;
    private void Start()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obs"))
        {
            score = score + 1; 
            scoreText.text = "Puntuación: ".ToString() + score;
        }
    }
}
