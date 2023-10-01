using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator anim;
    float powerHit = 0f;
    public bool charged = false;


    private void Update()
    {
        Attack();
    }

    void Attack()
    {
        Debug.Log(powerHit);

        if (Input.GetKeyDown(KeyCode.Space) && powerHit == 0)
        {
            powerHit = 0;
            anim.SetFloat("X", 0);

            anim.SetFloat("Y", 1);
            powerHit = Time.time;
            charged = true;
            Debug.Log("charged " + charged);

        }
        else if (charged && Time.timeScale > powerHit + 1f)
        {
            Debug.Log("last hi: " + powerHit);
            anim.SetFloat("X", 1);

            anim.SetFloat("Y", 1);
        }
        else if (Time.timeScale > powerHit + 2f)
        {
            Debug.Log("none");
            anim.SetFloat("X", 0);

            anim.SetFloat("Y", 0);
            charged = false;
            powerHit = 0;
        }
    }
}
