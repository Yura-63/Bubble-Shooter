using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(1);
    }
    public void BackMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Debug.Log("Exit!");
        Application.Quit();
    }
    public void Link_VK()
    {
        Application.OpenURL("https://vk.com/yuri.moiseev");
    }
}
