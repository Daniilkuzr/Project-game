using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI level;
    public int lv;
    public PlayerController pl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lv = pl.currentLevel;
       
        level.text = string.Format("level {0}",lv);
    }
}
