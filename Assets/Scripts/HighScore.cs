using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text scoretext;
    public int score;
    void Start()
    {
        if(PlayerPrefs.HasKey("musicVolume"))
        {
            LoadScore();
        }
    }
    private void LoadScore()
    {
        score = PlayerPrefs.GetInt("score");
        scoretext.text = score.ToString();
    }
}
