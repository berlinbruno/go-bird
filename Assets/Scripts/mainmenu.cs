using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("Level_0");
    }
    public void quit()
    {
        Application.Quit();
    }
}
