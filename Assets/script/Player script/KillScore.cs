using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class KillScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI kill;

    public static int kills=0;
    public PlayerController pl;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        kill.text = string.Format("Kill {0}", kills);
    }
}
