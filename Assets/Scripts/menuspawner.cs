using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuspawner : MonoBehaviour
{
    public GameObject gameovermenu;
    public GameObject pausemenu;

    public bool a = false;
    public bool b = false;
    public void gameover()
    {
        Instantiate(gameovermenu,Vector3.zero,Quaternion.identity);
    }

    public void pause()
    {
        if(a == false)
        {
            Debug.Log(b);
            if(b == false)
            {
                Instantiate(pausemenu,Vector3.zero,Quaternion.identity);
                Time.timeScale = 0;
            }
        }

    }
}
