using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjecTrigger : MonoBehaviour
{


    public void OnTriggerEnter(Collider other)
    {
         transform.position = new Vector3 (0, 0, +50);
    }
}
