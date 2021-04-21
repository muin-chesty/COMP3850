using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLevelOne : MonoBehaviour
{
    public GameObject closingTransition;
    public float startsIn = 1f;
    private float timer;
    private bool isClicked = false;

    private void Update()
    {
        if (isClicked)
        {
            closingTransition.SetActive(true);
            timer += Time.deltaTime;
            if (timer >= startsIn)
            {
                timer = 0f;
                SceneManager.LoadScene("Level 1-Packing");
                isClicked = false;
            }
        }

    }
    public void LoadLevelOne()
    {
        isClicked = true;
    }
}
