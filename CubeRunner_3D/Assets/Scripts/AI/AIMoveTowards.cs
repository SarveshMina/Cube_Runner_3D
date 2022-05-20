using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMoveTowards : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float rawSpeed = 100f;

    private bool isWandering = false;
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
        if (isWalking == true)
        {
            transform.position -= transform.forward * moveSpeed * Time.deltaTime;
        }
    }

    IEnumerator Wander ()
    {
        int walkTime = Random.Range(0, 10);
        int walkWait = Random.Range(0, 0);
        int walkLorR = Random.Range(1, 1);

        isWandering = true;

        yield return new WaitForSeconds(walkWait);

        if (walkLorR == 1)
        {
            isWalking = true;
            yield return new WaitForSeconds(walkTime);
            isWalking = false;
        }
        

        

        isWandering = false;
    }
}
