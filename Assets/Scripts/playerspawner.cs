using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerspawner : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
     Instantiate(player,Vector3.zero,Quaternion.identity);
    }
}
