using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitCustomisationLevel : MonoBehaviour
{
    public GameObject closingTransition;
    public float startsIn = 1f;
    private float timer;
    private bool isClicked = false;

    private void Update()
    {
        if(isClicked)
        {
            closingTransition.SetActive(true);
            timer += Time.deltaTime;
            if (timer >= startsIn)
            {
                timer = 0f;
                SceneManager.LoadScene("CharacterCreator");
                isClicked = false;
            }
        }

    }
    public void LoadCustomisationLevel()
    {
        isClicked = true;
    }
}
