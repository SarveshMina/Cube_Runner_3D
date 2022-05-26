using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIRotateRight : MonoBehaviour {

    public float moveSpeed = 3f;
    public float rawSpeed = 100f;

    private bool isWandering = false;
    private bool isRotatingRight = false;


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
            transform.Rotate(transform.up * moveSpeed);
        }
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
            isRotatingRight = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingRight = false;
        }

        isWandering = false;
    }
}
