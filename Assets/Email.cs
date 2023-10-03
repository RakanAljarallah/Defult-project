using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

using TMPro;

public class Email : MonoBehaviour
{
    // Start is called before the first frame update
    private string email = "";
    [SerializeField] TMP_InputField userInput;
    [SerializeField] TMP_Text displayText;
    [SerializeField] Animator animator;



    public void AddEmail()
    {
        email = userInput.text;
    }

    public void DisplayEmail()
    {
        displayText.text = email;
    }

    public void isValidEmail()
    {
        string recivedEmail = userInput.text;

        if (!recivedEmail.Contains('@'))
        {
            animator.enabled = true;
        }
        else
        {
            animator.enabled = false;
        }
    }

}
