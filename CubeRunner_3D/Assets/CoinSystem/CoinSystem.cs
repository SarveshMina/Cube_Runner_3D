using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinSystem : MonoBehaviour
{
    public Text coinDisplayText;
    public int currentCoins = 0;
    public AudioClip coinSound;
    [SerializeField] PlayerMovement playerMovement;

    void Start()
    {
        if (PlayerPrefs.HasKey("Gamecoin"))
        {
            currentCoins = PlayerPrefs.GetInt("Gamecoin");
        } 
        else
        {
            currentCoins = 0;
        }

        coinDisplayText.text = "Coins: " + currentCoins;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject);
            return;
        }

        if (col.tag == "Coin")
        {
            Destroy(col.gameObject);
            currentCoins++;
            playerMovement.forwardForce += playerMovement.speedIncreaseAsPerScore;
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            PlayerPrefs.SetInt("Gamecoin", currentCoins);
            coinDisplayText.text = "Coins: " + currentCoins;
        }
    }
}
