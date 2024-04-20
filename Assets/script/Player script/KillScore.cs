using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class KillScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI kill;
    public int kills;
    public PlayerController pl;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        kills = pl.Kill;

        kill.text = string.Format("Kill {0}", kills);
    }
}
