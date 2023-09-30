using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    // Start is called before the first frame update
    private void Start()
    {
        transform.LookAt(pointA);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "A")
        {
            transform.LookAt(pointB);
        }
        else if (other.transform.tag == "B")
        {
            transform.LookAt(pointA);
        }
    }

}
