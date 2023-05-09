using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemiddle : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D Others) 
    {
       Destroy(gameObject);
    }
}
