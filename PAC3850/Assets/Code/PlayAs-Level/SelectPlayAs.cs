using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectPlayAs : MonoBehaviour
{
    public void LoadChildSection()
    {
        SceneManager.LoadScene("ChildInfo");
    }

    public void LoadParentSection()
    {
        SceneManager.LoadScene("ParentInfo");
    }
}
