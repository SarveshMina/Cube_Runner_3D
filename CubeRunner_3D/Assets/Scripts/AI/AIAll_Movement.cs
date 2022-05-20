using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAll_Movement : MonoBehaviour
{

    public float moveSpeed = 3f;
    public float rawSpeed = 100f;

    private bool isWandering = false;
    //   private bool isRotatingLeft = false;
    private bool isRotatingRight = false;
    private bool isWalking = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isWandering == false)
        {
            StartCoroutine(Wander());
        }
        if (isRotatingRight == true)
        {
            transform.Rotate(transform.up);
        }
        //      if (isRotatingLeft == true)
        //    {
        //      transform.Rotate(transform.up * Time.deltaTime * -moveSpeed);
        //}
    }

    IEnumerator Wander()
    {
        int rotTime = Random.Range(0, 50);
        int rotateWait = Random.Range(1, 1);
        int rotateLorR = Random.Range(1, 1);
        int walkWait = Random.Range(1, 4);
        int walkTime = Random.Range(1, 5);

        isWandering = true;

        yield return new WaitForSeconds(walkWait);
        isWalking = true;
        yield return new WaitForSeconds(walkTime);
        isWalking = false;
        yield return new WaitForSeconds(rotateWait);
        if (rotateLorR == 1)
        {
            isRotatingRight = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingRight = false;
        }

        /*       if (rotateLorR == 1)
                    {
                        isRotatingLeft = true;
                        yield return new WaitForSeconds(rotTime);
                        isRotatingLeft = false;
                    }*/

        isWandering = false;
    }
}