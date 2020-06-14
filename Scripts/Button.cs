using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void openLink()
    {
        Application.OpenURL("https://www.google.com/");
    }

    public void exitGame()
    {
        Application.Quit();
    }

}
