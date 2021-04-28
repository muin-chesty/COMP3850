using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AskToFAQ : MonoBehaviour
{
    public void LoadParentQuestions()
    {
        SceneManager.LoadScene("ParentQuestions");
    }
}
