using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pipespawner : MonoBehaviour
{
    public GameObject pipe;
    private float timer = 0;
    public float heightoffset = 10;
    public float spawnrate = 6;
    public void Start()
    {
        spawnpipe();
    }

    void Update()
    {
        
        if(timer < spawnrate)
        {            
            timer += Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer = 0;
            spawnrate = Random.Range(4,7);
            
        }
    }

    public void spawnpipe()
    {
        float highpoint = transform.position.y + heightoffset;
        float lowpoint = transform.position.y - heightoffset + 2;
        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(highpoint,lowpoint),0),Quaternion.identity);
    }
}
