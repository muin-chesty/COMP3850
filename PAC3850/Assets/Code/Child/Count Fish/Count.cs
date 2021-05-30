using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Count : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject four;

    public GameObject correctPanel;
    public GameObject anotherGoPanel;
    public GameObject tryAgainPanel;

    [Space]
    public GameObject closingCanvas;
    private bool isCorrect = false;
    private float timer = 0f;
    public void OneButton()
    {
        one.SetActive(false);
        if(anotherGoPanel.activeSelf == false)
        {

            anotherGoPanel.SetActive(true);
        }
        else if (tryAgainPanel.activeSelf == false)
        {

            tryAgainPanel.SetActive(true);
        }

    }

    public void FourButton()
    {
        four.SetActive(false);
        if (anotherGoPanel.activeSelf == false)
        {

            anotherGoPanel.SetActive(true);
        }
       else if (tryAgainPanel.activeSelf == false)
        {

            tryAgainPanel.SetActive(true);
        }

    }

    public void TwoButton()
    {
        two.SetActive(false);
        correctPanel.SetActive(true);
        isCorrect = true;
    }


    // Update is called once per frame
    void Update()
    {
        if(isCorrect)
        {
            timer += Time.deltaTime;
            if(timer >= 2f)
            {
                closingCanvas.SetActive(true);
                if(timer >= 4f)
                {
                    SceneManager.LoadScene("Hallway");
                }
            }
        }

    }
}
