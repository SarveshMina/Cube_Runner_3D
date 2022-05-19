using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void startGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GoToCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Quit_Menu()
    {
        Application.Quit();
    }
}
