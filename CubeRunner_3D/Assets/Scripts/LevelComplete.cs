using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel ()
    {
        SceneManager.LoadScene("Credits");
    }
}
