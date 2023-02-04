using UnityEngine;
public class Scene : MonoBehaviour
{
     [SerializeField] private string nameScene;
     

    public string NameScene { get => nameScene; set => nameScene = value; }
    public void BottonBack()
    {
        ControllerScene.SetScene(nameScene);
    }
}
