using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public bool gameHasEnded = false;
//    public float restartDelay = 2f;
    public GameObject completeLevelUI;
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
            Debug.Log("Game ended");
            gameHasEnded = true;

            //Restarting game after this.
//            Invoke("Restart", restartDelay);        
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
