using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator anim;

    private void Update()
    {
        Attack();
    }

    void Attack()
    {
        Debug.Log(Input.GetKeyDown(KeyCode.Space));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetFloat("X", 0);

            anim.SetFloat("Y", 1);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetFloat("X", 1);

            anim.SetFloat("Y", 1);
        }
        else
        {
            anim.SetFloat("X", 0);

            anim.SetFloat("Y", 0);
        }
    }
}
