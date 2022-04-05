using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public string MainMenu;
    public void MainClick()
    {
        SceneManager.LoadScene(MainMenu);
    }
}
