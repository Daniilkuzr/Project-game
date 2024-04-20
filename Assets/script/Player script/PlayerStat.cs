using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    public CharacterScriptableObject characterData;


    float currentHealth;
    float currentRecovery;
    float currentMovespeed;
    float currentMight;
    GameObject currentProjecttileSpeed;


    private void Awake()
    {
        currentHealth = characterData.MaxHealth;
        currentRecovery = characterData.Recovery;
        currentMovespeed = characterData.MoveSpeed;
        currentMight = characterData.Might;
        currentProjecttileSpeed = characterData.ProjectileSpeed;
    }

}
