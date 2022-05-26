using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text highScore;

    void Start()
    {
        highScore.text = "High Score: " + PlayerPrefs.GetInt("High_Score", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        int PlayerScore = int.Parse(scoreText.text);
        scoreText.text = player.position.z.ToString("0");
        PlayerPrefs.SetInt("Current_Score", PlayerScore);

        if (PlayerScore > PlayerPrefs.GetInt("High_Score", 0))
        {
            PlayerPrefs.SetInt("High_Score", PlayerScore);
            highScore.text = "High Score: " + PlayerScore.ToString();
        }

        
    }

    public void ResetScore()
    {
        PlayerPrefs.DeleteKey("High_Score");
    }
}