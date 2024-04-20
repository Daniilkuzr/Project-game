using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLTarget : MonoBehaviour
{
    public GameObject pl;
    public Transform tra;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            {
                pl = collision.gameObject;
                tra = pl.transform;
            }
        }
    }
}
