using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
   public menuspawner pausemenus;
   public void Start() {
      pausemenus = GameObject.FindGameObjectWithTag("Menu").GetComponent<menuspawner>();
   }
   public void Update()
   {
      pausemenus.b = gameObject.activeSelf;
   }
   public void resume()
   { 
    Time.timeScale = 1;
    Destroy(gameObject);
    pausemenus.b = false;
   }
   public void mainmenu()
   {
    SceneManager.LoadScene("Menu");
    Time.timeScale = 1;
   }
   public void quit()
   {
    Application.Quit();
   }
}
