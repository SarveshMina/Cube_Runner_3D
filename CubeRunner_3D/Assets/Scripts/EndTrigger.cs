using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManger gameManager;

    public void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
    }
}
