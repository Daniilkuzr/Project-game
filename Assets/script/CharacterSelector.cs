using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    public static CharacterSelector instance;
    public CharacterScriptableObject characterData;

    void Awake()
    {
        //if(instance==0)
        //{
        //    instance = this;
        //    DontDestroyOnLoad(gameObject);
        //}
    }


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
