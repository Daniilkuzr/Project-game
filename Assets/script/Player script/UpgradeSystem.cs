using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSystem : MonoBehaviour
{
    public GameObject can;
    public GameObject player;
    public PlayerController pl_exp;
    public int currentexp = 0;
    public GameObject bt1;
    public GameObject bt2;
    public GameObject bt3;
    public GameObject weapon1;
    public GameObject weapon2;
    public GameObject weapon3;
    public GameObject weapon4;
    public int WeaponNumber;
    public int UpgradeWeaponNumber = 0;
    public enum GameState
    {
        Gameplay,
        Paused,
        GameOver

    }
    public GameState currentState;
    public GameState previousState;
    [Header("UI")]
    public GameObject pauseScrean;

    void Awake()
    {
        DisableScreaen();
    }
    void Start()
    {
        
    }

    void WeaponUpgrade()
    {
        if(WeaponNumber==0)
        {
            switch (UpgradeWeaponNumber)
            {
                case 0:
                    
                    UpgradeWeaponNumber++;
                    break;
                case 1:
                    UpgradeWeaponNumber++;
                    break;
                case 2:
                    UpgradeWeaponNumber++;
                    break;
                case 3:
                    break;
            }

        }
        else if(WeaponNumber==1)
        {
            switch (UpgradeWeaponNumber)
            {
                case 0:
                    UpgradeWeaponNumber++;
                    break;
                case 1:
                    UpgradeWeaponNumber++;
                    break;
                case 2:
                    UpgradeWeaponNumber++;
                    break;
                case 3:
                    break;
            }
        }
        else if(WeaponNumber==2)
        {
            switch (UpgradeWeaponNumber)
            {
                case 0:
                    UpgradeWeaponNumber++;
                    break;
                case 1:
                    UpgradeWeaponNumber++;
                    break;
                case 2:
                    UpgradeWeaponNumber++;
                    break;
                case 3:
                    break;
            }
        }
        else if(WeaponNumber==3)
        {
            switch (UpgradeWeaponNumber)
            {
                case 0:
                    UpgradeWeaponNumber++;
                    break;
                case 1:
                    UpgradeWeaponNumber++;
                    break;
                case 2:
                    UpgradeWeaponNumber++;
                    break;
                case 3:
                    break;
            }
        }
    }

    public void ChangeState(GameState newState)
    {
        currentState = newState;
    }

    public void ResumeGame()
    {
        if (currentState == GameState.Paused)
        {
            ChangeState(previousState);
            Time.timeScale = 1f;
            pauseScrean.SetActive(false);
            Debug.Log("Game is resume");
        }
    }

    void CheckForPauseAndResume()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (currentState == GameState.Paused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void DisableScreaen()
    {
        pauseScrean.SetActive(false);
    }

    private void Update()
    {
        switch (currentState)
        {
            case GameState.Gameplay:
                CheckForPauseAndResume();
                break;

            case GameState.Paused:
                CheckForPauseAndResume();
                break;

            case GameState.GameOver:
                break;

            default:
                Debug.LogWarning("State does not exist");
                break;
        }

        if(pl_exp.currentLevel>currentexp)
        {
            currentexp++;
            UpgradePl();
        }
    }

    void UpgradePl()
    {
        can.SetActive(true);
        PauseGame();
    }
   
    void UpgradeBt()
    {
        ResumeGame();
    }

    void UpgradeWeapon(int weapon)
    { 
        if(weapon==0)
        {

        }
        else if(weapon==1)
        {

        }
        else if(weapon==2)
        {

        }
        else if(weapon==3)
        {

        }
    
    
    }

    public void PauseGame()
    {
        if (currentState != GameState.Paused)
        {
            previousState = currentState;
            ChangeState(GameState.Paused);
            Time.timeScale = 0f;
            pauseScrean.SetActive(true);
            Debug.Log("Game is paused");
        }
    }
}
