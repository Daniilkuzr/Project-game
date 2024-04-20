using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropEXP : MonoBehaviour
{
    public float  exp;
    public GameObject expbox;
    public GameObject player;
    private PlayerController pl;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            PlayerController pl = collision.gameObject.GetComponent<PlayerController>();
            pl.TakeEXP(exp);
            Destroy(expbox);
        }    
        

    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
