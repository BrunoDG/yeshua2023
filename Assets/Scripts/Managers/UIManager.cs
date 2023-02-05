using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject MainMenuCanvas;
    public GameObject QuizCanvas;
    public GameObject LoseCanvas;
    public GameObject WinCanvas;

    void Awake()
    {
        MainMenuCanvas.SetActive(true);
        QuizCanvas.SetActive(false);
        LoseCanvas.SetActive(false);
        WinCanvas.SetActive(false);
    }

    public void StartGame()
    {
        MainMenuCanvas.SetActive(false);
    }

}
