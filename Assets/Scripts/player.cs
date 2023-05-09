using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 7;
    public Rigidbody2D myrb;
    public logicscript logic;
    public menuspawner menu;
    public CircleCollider2D playercollider;
    public Animator animator;

    public bool playerisalive = true;
    private bool notvisible = false;

    
    AudioManager audioManager;
    private void Awake(){
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    void Start()
    {
      logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicscript>();
      menu = GameObject.FindGameObjectWithTag("Menu").GetComponent<menuspawner>();
    }

    void Update()
    {
      for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
              if(playerisalive == true)
              {
                 myrb.velocity = Vector2.up * speed;
                audioManager.PlaySFX(audioManager.touch);
              }
            }
        }
        if(transform.position.y > 25 || transform.position.y < -25)
        {
          playerisalive = false;
          notvisible = true;
        }
        if(playerisalive == false)
        {
          transform.Rotate(Vector3.forward*5);
          menu.gameover();
          audioManager.PlaySFX(audioManager.death);
         }
         if(playerisalive == false && notvisible == true)
         {
          Destroy(gameObject);
         }
    }
    public void OnTriggerEnter2D(Collider2D Others) 
    {
       logic.addscore(1);
    }

    public void OnCollisionEnter2D(Collision2D other) 
    {
      playerisalive = false;
      playercollider.enabled = false;
    }
}