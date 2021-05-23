using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class XRay : MonoBehaviour
{
    public GameObject player;
    public GameObject parent;
    public GameObject rightDoor;
    public GameObject leftDoor;
    public GameObject canvas;
    public GameObject enterButton;
    public GameObject openButton;
    public GameObject elevatorTextPanel;
    public GameObject hintImage;
    public GameObject levelTwoButton;
    public GameObject elevatorClosingCanvas;
    

    private float timer = 0f;
    [SerializeField]
    private float delay = 1f;

    private bool isOpenButtonClicked = false;
    private bool isEnterButtonClicked = false;
    private bool isLevelTwoClicked = false;


    public void GoToLevelTwo()
    {
        
        elevatorClosingCanvas.SetActive(true);
        timer = 0f;
        isLevelTwoClicked = true;
    }
    public void EnterLift()
    {
        enterButton.SetActive(false);
        isEnterButtonClicked = true;
        elevatorTextPanel.SetActive(true);
        timer = 0f;
    }
    public void OpenLift()
    {
        leftDoor.SetActive(true);
        rightDoor.SetActive(true);
        openButton.SetActive(false);
        canvas.GetComponent<Animator>().enabled = true;
       
        hintImage.SetActive(false);
        isOpenButtonClicked = true;
        timer = 0f;
    }
    void Update()
    {
        if(isLevelTwoClicked)
        {
            timer += Time.deltaTime;
            if(timer >=  delay)
            {
                SceneManager.LoadScene("2-X-Ray");
                // END OF LEVEL
            }
        }

        if(isOpenButtonClicked)
        {
            timer += Time.deltaTime;
            if(timer >= delay)
            {
                enterButton.SetActive(true);
                isOpenButtonClicked = false;
            }
        }
        if(isEnterButtonClicked)
        {
            timer += Time.deltaTime;
            if (timer >= delay)
            {
               
                parent.SetActive(true);
                player.SetActive(true);
                
                if(timer >= delay + 0.5f)
                {
                    isEnterButtonClicked = false;
                    levelTwoButton.SetActive(true);
                }
                
            }
        }
    }
}
