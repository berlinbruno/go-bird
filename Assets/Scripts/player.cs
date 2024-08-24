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
    private void Awake()
    {
        GameObject audioObject = GameObject.FindGameObjectWithTag("Audio");
        if (audioObject != null)
        {
            audioManager = audioObject.GetComponent<AudioManager>();
        }
        else
        {
            Debug.LogError("Audio object not found in the scene!");
        }
    }

    void Start()
    {
        GameObject logicObject = GameObject.FindGameObjectWithTag("Logic");
        if (logicObject != null)
        {
            logic = logicObject.GetComponent<logicscript>();
        }
        else
        {
            Debug.LogError("Logic object not found in the scene!");
        }

        GameObject menuObject = GameObject.FindGameObjectWithTag("Menu");
        if (menuObject != null)
        {
            menu = menuObject.GetComponent<menuspawner>();
        }
        else
        {
            Debug.LogError("Menu object not found in the scene!");
        }
    }


    void Update()
    {
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                if (playerisalive == true)
                {
                    myrb.velocity = Vector2.up * speed;

                    if (audioManager != null)
                    {
                        audioManager.PlaySFX(audioManager.touch);
                    }
                    else
                    {
                        Debug.LogError("AudioManager not found!");
                    }
                }
            }
        }

        if (transform.position.y > 25 || transform.position.y < -25)
        {
            playerisalive = false;
            notvisible = true;
        }

        if (playerisalive == false)
        {
            transform.Rotate(Vector3.forward * 5);
            menu.gameover();

            if (audioManager != null)
            {
                audioManager.PlaySFX(audioManager.death);
            }
        }

        if (playerisalive == false && notvisible == true)
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