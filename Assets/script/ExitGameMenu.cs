using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitGameMenu : MonoBehaviour
{
    public void exitMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }
}
