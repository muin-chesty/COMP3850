using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ask : MonoBehaviour
{
    private bool isQuestionSubmitted = false;
    private bool backButtonClicked = false;
    private float timer = 0f;

    [SerializeField]
    private float delay = 10f;
    [SerializeField]
    private float backbuttonDelay = 2f;

    [SerializeField]
    private GameObject popupCanvas;
    [SerializeField]
    private GameObject outroCanvas;
    void Start()
    {
        popupCanvas.SetActive(false);
        outroCanvas.SetActive(false);
    }


    void Update()
    {
        if (isQuestionSubmitted)
        {
            timer += Time.deltaTime;
            if(timer >= (delay - 1f))
            {
                outroCanvas.SetActive(true);
            }
            if(timer >=  delay)
            {
                SceneManager.LoadScene("Paths");
                isQuestionSubmitted = false;
                timer = 0f;
            }
        }

        if(backButtonClicked)
        {
            timer += Time.deltaTime;
            if(timer >= backbuttonDelay)
            {
                timer = 0f;
                backButtonClicked = false;
                SceneManager.LoadScene("Paths");
            }
        }
    }
    public void BackButton()
    {
        backButtonClicked = true;
        outroCanvas.SetActive(true);
    }
    public void SubmitQuestion()
    {
        isQuestionSubmitted = true;
        popupCanvas.SetActive(true);
    }
}
