using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Controller : MonoBehaviour
{
    public int Score;
    public Text scoreText;

    public Text scoreFinal;

    public Text scoreRun;

    public static Game_Controller instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        scoreFinal.text = PlayerPrefs.GetInt("scoreFinal").ToString();

        scoreRun.text = PlayerPrefs.GetInt("scoreAtual").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
