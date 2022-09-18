using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    public List<GameObject> Grounds;
    public float offset = 45f;

    // Start is called before the first frame update
    void Start()
    {
        if (Grounds != null && Grounds.Count > 0)
        {
            Grounds = Grounds.OrderBy(r => r.transform.position.z).ToList();
        }
    }

    public void MoveGround ()
    {
        GameObject moveGround = Grounds[0];
        Grounds.Remove(moveGround);
        float newZ = Grounds[Grounds.Count - 1].transform.position.z + offset;
        moveGround.transform.position = new Vector3(0, 0, newZ);
        Grounds.Add(moveGround);
    }
}
