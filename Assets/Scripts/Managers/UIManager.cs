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
        MainMenuCanvas.SetActive(true);
        // deactivating the GrayScale Filter
        FilteredCanvas.SetActive(false);

        //QuizCanvas.SetActive(false);
        //LoseCanvas.SetActive(false);
        //WinCanvas.SetActive(false);

    }


    public void StartGame()
    {
        MainMenuCanvas.SetActive(false);
        FilteredCanvas.SetActive(true);
    }

}
