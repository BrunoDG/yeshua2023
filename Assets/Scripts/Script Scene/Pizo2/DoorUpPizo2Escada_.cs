﻿using UnityEngine;

public class DoorUpPizo2Escada_ : MonoBehaviour , IInteractable
{
    [SerializeField] private string stringScene;
        
    
        public void Interact()
        {
            SetScene();
        }
        private void SetScene()
        {
            ControllerScene.SetScene(stringScene);
        }
}
