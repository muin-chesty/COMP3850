using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private float timer = 0f;
    [Tooltip("Number of seconds the level will wait until going to the next level")]
    [SerializeField]
    private float startsIn = 2f;


    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= startsIn)
        {
            timer = 0f;
          //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
