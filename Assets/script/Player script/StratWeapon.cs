using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StratWeapon : MonoBehaviour
{
    public GameObject menu;
    public GameObject bt1;
    public GameObject bt2;
    public GameObject bt3;
    public GameObject bt4;
    public GameObject weapon1;
    public GameObject weapon2;
    public GameObject weapon3;
    public GameObject weapon4;
    public int StartWeapon;


    void Start()
    {

    }

    public void ChoiceWeapon1()
    {
        if(bt1)
        {
            StartWeapon = 0;
            weapon1.SetActive(true);
            ResumeGame();
        }
    }

    public void ChoiceWeapon2()
    {
        if (bt1)
        {
            StartWeapon = 0;
            weapon2.SetActive(true);
            ResumeGame();
        }
    }
    public void ChoiceWeapon3()
    {
        if (bt1)
        {
            StartWeapon = 0;
            weapon3.SetActive(true);
            ResumeGame();
        }
    }

    public void ChoiceWeapon4()
    {
        if (bt1)
        {
            StartWeapon = 0;
            weapon4.SetActive(true);
            ResumeGame();
        }
    }

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
        pauseScrean.SetActive(true);
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
    }

    void UpgradePl()
    {
        PauseGame();
    }

    void UpgradeBt()
    {
        ResumeGame();
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
