using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectParentQuestions : MonoBehaviour
{
    public void LoadParentQuestions()
    {
        SceneManager.LoadScene("ParentQuestions");
    }
}
