using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameovermenu : MonoBehaviour
{
    public menuspawner menu;

    public static gameovermenu instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;

        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    public void Start() 
    {
        menu = GameObject.FindGameObjectWithTag("Menu").GetComponent<menuspawner>();

    }
    public void Update()
    {
        bool active = gameObject.activeSelf;
        menu.a = active;

    }
    public void playagain()
    {
        SceneManager.LoadScene("Level_0");
    }
    public void quit()
        {
            Application.Quit();
        }
}
