using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public bool gameHasEnded = false;
//    public float restartDelay = 2f;
    public GameObject completeLevelUI;
    public GameObject GameOverUI;
    public GameObject levelUI;

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
        levelUI.SetActive(false);
    }

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            if (gameHasEnded == true)
            {
                GameOverUI.SetActive(true);
                levelUI.SetActive(false);
            }      
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
