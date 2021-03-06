using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float GoRight = 1000f;   // Force to go left
    public float GoLeft = -1000f;   // Force to go Right
    public float speedIncreaseAsPerScore = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void addForce ()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

            // Add a forward force
            addForce();

            if (Input.GetKey("right"))            //Press 'd' to move right
            {
                rb.AddForce(GoRight * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            else if (Input.GetKey("left"))      //Press 'a' to move left
            {
                rb.AddForce(GoLeft * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (rb.position.y < -1f)
            {
                FindObjectOfType<GameManger>().EndGame();
            }
    }
}

