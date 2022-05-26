using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManger gameManager;
    public PlayerMovement movement;

    public void OnTriggerEnter ()
    {
        movement.enabled = false;
        gameManager.CompleteLevel();
    }
}
