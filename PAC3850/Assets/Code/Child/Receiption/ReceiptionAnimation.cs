using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReceiptionAnimation : MonoBehaviour
{
  /*  public GameObject receiptionist;
    public GameObject player;
    public GameObject greetings;
    public GameObject hiButton;
    public GameObject playerResponse;
    public GameObject receiptionistResponse;
    public GameObject awesomeButton;
*/
    [Header("Greetings Panel")]
    public GameObject greetingsPanel;

    [Space]
    [SerializeField]
    private float delay = 2f;

    [Header("Parent and Child")]
    [Space]
    public GameObject parent;
    public GameObject child;

    [Header("Response Panel")]
    [Space]
    public GameObject responsePanel;

    [Header("Answer from Receiption Panel")]
    [Space]
    public GameObject answerPanel;

    [Header("Play Button")]
    [Space]
    public GameObject playButton;
    private bool isPlayClicked = false;

    [Header("Closing Canvas")]
    public GameObject newClosingCanvas;

    private float timer = 0.0f;
    private float timeForTransition = 1f;
    private float timeForParentChild = 6f;
    private float levelEndTimer = 0.0f;

    public Text greetingsText;

    private void Start()
    {
        greetingsText.text = "  Receiptionist: Hello " + Child.first_name + "! Welcome to Heart Centre! ";
    }


    public void PlayButton()
    {
      
        isPlayClicked = true;
        newClosingCanvas.SetActive(true);

    }

    void Update()
    {
        if(isPlayClicked)
        {
            levelEndTimer += Time.deltaTime;
            if(levelEndTimer >= timeForTransition)
            {
                SceneManager.LoadScene("CountFish");
            }
        }

        timer += Time.deltaTime;
        if(timer >= timeForTransition)
        {
            greetingsPanel.SetActive(true);
        }
        if(timer >= timeForParentChild)
        {
            parent.SetActive(true);
            child.SetActive(true);
        }
        if(timer >= ( timeForParentChild + 1f ))
        {
            responsePanel.SetActive(true);
        }
        if(timer >= (timeForParentChild + timeForParentChild + 1f))
        {
            answerPanel.SetActive(true);
        }
        if(timer >= ((timeForParentChild * 4) - 2f))
        {
            playButton.SetActive(true);
        }


        /*        if(isHiButtonClicked == false && isAwesomeButtonClicked == false)
                {
                    timer += Time.deltaTime;
                    if (timer >= delay)
                    {
                        greetings.SetActive(false);
                        if (timer >= delay + 1f)
                        {
                            receiptionist.SetActive(false);
                            if (timer >= delay + 2f)
                            {
                                player.SetActive(true);
                                if (timer >= delay + 3f)
                                {
                                    hiButton.SetActive(true);
                                    timer = 0f;
                                }

                            }

                        }

                    }
                }


                if(isHiButtonClicked)
                {
                    hiButton.SetActive(false);
                    timer += Time.deltaTime;
                    if(timer >= delay - 1f)
                    {
                        playerResponse.SetActive(true);
                        if(timer >= delay + 2f)
                        {
                            playerResponse.SetActive(false);
                            if(timer >= delay + 3f)
                            {
                                player.SetActive(false);
                                if(timer >= delay + 4f)
                                {
                                    receiptionist.SetActive(true);
                                    if(timer >= delay + 5f)
                                    {
                                        receiptionistResponse.SetActive(true);
                                        if(timer >= delay + 10f)
                                        {
                                            receiptionistResponse.SetActive(false);
                                            if(timer >= delay + 11f)
                                            {
                                                receiptionist.SetActive(false);
                                                if(timer >= delay + 12f)
                                                {
                                                    player.SetActive(true);
                                                    if(timer >= delay + 13f)
                                                    {
                                                        awesomeButton.SetActive(true);
                                                        isHiButtonClicked = false;
                                                        timer = 0f;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if(isAwesomeButtonClicked)
                {
                    awesomeButton.SetActive(false);
                    timer += Time.deltaTime;
                    if(timer >= delay - 1f)
                    {
                        SceneManager.LoadScene("HeightAndWeight");
                    }
                }
            }*/
    }
}
