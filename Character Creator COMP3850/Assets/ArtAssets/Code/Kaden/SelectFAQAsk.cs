using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectFAQAsk : MonoBehaviour
{
    public void LoadParentFAQ()
    {
        SceneManager.LoadScene("ParentFAQ");
    }

    public void LoadParentAsk()
    {
        SceneManager.LoadScene("ParentAsk");
    }
}
