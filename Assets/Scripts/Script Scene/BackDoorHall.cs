using UnityEngine;

public class BackDoorHall : MonoBehaviour  , IInteractable
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
