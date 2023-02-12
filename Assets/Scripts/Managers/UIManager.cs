using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject MainMenuCanvas;
    public GameObject QuizCanvas;
    public GameObject LoseCanvas;
    public GameObject WinCanvas;

    public GameObject FilteredCanvas;

    void Awake()
    {
        OpenMainMenu();
    }

    /// <summary>
    /// Function that opens all menus and starts the game.
    /// </summary>
    public void OpenMainMenu()
    {
        MainMenuCanvas.SetActive(true);
        // deactivating the GrayScale Filter
        FilteredCanvas.SetActive(false);

        QuizCanvas.SetActive(false);
        LoseCanvas.SetActive(false);
        WinCanvas.SetActive(false);
    }

    /// <summary>
    /// Close Main Menu and starts the GrayScale Canvas.
    /// </summary>
    public void StartGame()
    {
        MainMenuCanvas.SetActive(false);
        // Gray Scaling the game
        FilteredCanvas.SetActive(true);
    }

    /// <summary>
    /// Calls the Challenge Quiz for the player to answer the question
    /// </summary>
    public void OpenQuiz()
    {
        Time.timeScale = 0;
        QuizCanvas.SetActive(true);
    }

    /// <summary>
    /// Closes the screen and returns to the game
    /// </summary>
    public void BackToGame()
    {
        Time.timeScale = 1;
        QuizCanvas.SetActive(false);
    }

}
