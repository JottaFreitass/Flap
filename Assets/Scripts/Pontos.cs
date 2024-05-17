using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontos : MonoBehaviour
{
    public Game_Controller controller;

    void Start()
    {
        controller = FindObjectOfType<Game_Controller>();
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        controller.Score ++;
        controller.scoreText.text = controller.Score.ToString();
    }

    
}