using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ScrolListener : MonoBehaviour
{
    [SerializeField] Scrollbar scrol;
    float timer = 100f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timere(timer));
    }

    // Update is called once per frame


    IEnumerator Timere(float time)
    {
        Debug.Log(time);
        scrol.value = time;
        yield return new WaitForSeconds(1f);
        if (time > 0) StartCoroutine(this.Timere(time - 4));
    }


}
