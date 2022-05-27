using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void backToMenu ()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GoToLevel_01()
    {
        SceneManager.LoadScene("Level_01");
    }

    public void GoToLevel_02()
    {
        SceneManager.LoadScene("Level_02");
    }
    
    public void RestartLevel()
    {
        SceneManager.LoadScene("Level_02");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
