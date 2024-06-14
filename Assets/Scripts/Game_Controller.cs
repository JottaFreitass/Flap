using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Controller : MonoBehaviour
{
    public int Score;
    public Text scoreText;

   public  Text scoreFinal;

   public bool IsFinal;

    public Text scoreRun;

    public static Game_Controller instance;

    // Start is called before the first frame update
    void Start()
    {
        if (IsFinal)
        {
            scoreRun.text = PlayerPrefs.GetInt("scoreAtual", 0).ToString();
            scoreFinal.text = PlayerPrefs.GetInt("scoreFinal", 0).ToString();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
