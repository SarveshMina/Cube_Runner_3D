using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIRotateLeft : MonoBehaviour
{

    public float moveSpeed = 3f;
    public float rawSpeed = 100f;

    private bool isWandering = false;
    private bool isRotatingLeft = false;

    void Start ()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isWandering == false)
        {
            StartCoroutine(Wander());
        }

        if (isRotatingLeft == true)
        {
            transform.Rotate(transform.up * -moveSpeed);
        }

        IEnumerator Wander()
        {
            int rotTime = Random.Range(0, 1000);
            int rotateWait = Random.Range(0, 0);
            int rotateLorR = Random.Range(1, 1);

            isWandering = true;

            yield return new WaitForSeconds(rotateWait);

            if (rotateLorR == 1)
            {
                isRotatingLeft = true;
                yield return new WaitForSeconds(rotTime);
                isRotatingLeft = false;
            }

            isWandering = false;

        }
    }
}
