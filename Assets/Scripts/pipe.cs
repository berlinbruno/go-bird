using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    public float pipespeed = 5;
    public int deadzone = -50;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * pipespeed) * Time.deltaTime;

        if (transform.position.x < -50)
        {
            Destroy(gameObject);
        }
    }
}
