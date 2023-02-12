using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour
{
    public UIManager uiManager;

    private void Start()
    {
        uiManager.GetComponent<UIManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        uiManager.OpenQuiz();
    }
}
