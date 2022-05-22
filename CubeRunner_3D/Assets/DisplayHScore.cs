using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHScore : MonoBehaviour
{
    public Text Display_HighScore;

    void Display_Text ()
    {
        Display_HighScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore").ToString();
    }
    
}
