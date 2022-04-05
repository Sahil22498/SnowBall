using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string GamePlay;

   
    public void StartGame()
    {
        SceneManager.LoadScene(GamePlay); 
    }

    public void QuitGame()
    {
        Application.Quit();
    }
   
}
