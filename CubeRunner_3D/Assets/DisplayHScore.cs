using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHScore : MonoBehaviour
{
    public Text Display_HighScore;
    public Text Display_CurrentScore;
    public Text Display_Coins;

    void Start ()
    {
        Display_HighScore.text = "High Score: " + PlayerPrefs.GetInt("High_Score").ToString();
        Display_CurrentScore.text = "Score: " + PlayerPrefs.GetInt("Current_Score").ToString();
        Display_Coins.text = "Coins: " + PlayerPrefs.GetInt("GameCoin").ToString();

    }
    
}
