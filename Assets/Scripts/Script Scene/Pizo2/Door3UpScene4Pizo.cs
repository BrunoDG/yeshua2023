using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door3UpScene4Pizo : MonoBehaviour , IInteractable
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
