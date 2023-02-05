using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScene2P2 : MonoBehaviour , IInteractable
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
