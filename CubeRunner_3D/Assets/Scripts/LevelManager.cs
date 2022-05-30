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

    public void RestartLevel_01()
    {
        SceneManager.LoadScene("Level_01");
    }

    public void RestartLevel_02()
    {
        SceneManager.LoadScene("Level_02");
    }

    public void RestartEndlessLevel ()
    {
        SceneManager.LoadScene("endless_level");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
