using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(anything());
    }

    // Update is called once per frame
    IEnumerator anything()
    {
        yield return new WaitForSeconds(3);
        Debug.Log("time out");
    }
}
