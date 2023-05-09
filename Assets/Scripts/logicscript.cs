using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logicscript : MonoBehaviour
{
    public int score = 0;
    public Text scoretext;
    private int a = 0;
    public void addscore(int scoretoadd)
    {
        score += scoretoadd;
        scoretext.text = score.ToString();
    }
    public void Update()
    {   
        if(score > a){
        PlayerPrefs.SetInt("score", score);
        a = score;
        }
    }
}
