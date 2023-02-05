using UnityEngine;
using UnityEngine.SceneManagement;
public class ControllerScene
{
    public static bool ActiveEndWindows;
    public static void SetScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }
    public static void SetSceneAsync(string nameScene)
    {
        SceneManager.LoadSceneAsync(nameScene);
    }
    public static void EndWindows()
    {
        if(ActiveEndWindows)
        Application.Quit();
    }
}
