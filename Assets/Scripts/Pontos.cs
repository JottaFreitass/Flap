using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontos : MonoBehaviour
{
    public Game_Controller controller;

    void Start()
    {
        if(!PlayerPrefs.HasKey("scoreFinal"))
        {
            PlayerPrefs.SetInt("scoreFinal", 0);
        }
        controller = FindObjectOfType<Game_Controller>();
    }

    void Update()
    {
        if(PlayerPrefs.GetInt("scoreFinal") < controller.Score)
        {
            PlayerPrefs.SetInt("scoreFinal", controller.Score);
        }

        PlayerPrefs.SetInt("scoreAtual", controller.Score);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        controller.Score ++;
        controller.scoreText.text = controller.Score.ToString();
    }

    
}