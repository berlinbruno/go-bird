using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoader : MonoBehaviour
{
    private float timeRemaining = 3;
    void Update()
    {
        timeRemaining -= Time.deltaTime;
       float Timer  = Mathf.FloorToInt(timeRemaining % 60);
       if(Timer <= 0)
       {
        timeRemaining = 1;
        SceneManager.LoadScene("Menu");
       }        
    }
}
