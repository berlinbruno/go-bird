using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChanger : MonoBehaviour
{
    public Sprite b1;
    public Sprite b2;
    public Sprite b3;
    public SpriteRenderer background;
    public logicscript logic;
    int x = 0;
    private float timeRemaining = 60;

    void Update()
    {
        timeRemaining -= Time.deltaTime;
       float Timer  = Mathf.FloorToInt(timeRemaining % 60);
       if(Timer <= 0)
       {
        timeRemaining = 60;
        x = x+1;
       }
        if(x == 3)
        {
            x = 0;
        }
        switch(x)
        {
            case 1:
            background.sprite = b1;
            gameObject.transform.localScale = new Vector3(4,3,0);
            break;
            case 2:
            background.sprite = b2;
            gameObject.transform.localScale = new Vector3(4,3,0);
            break;
            case 3:
            background.sprite = b3;
            gameObject.transform.localScale = new Vector3(4,3,0);
            break;
            default:
            background.sprite = b1;
            gameObject.transform.localScale = new Vector3(4,3,0);
            break;

        } 
    }
}
