using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReceiptionAnimation : MonoBehaviour
{
    public GameObject receiptionist;
    public GameObject player;
    public GameObject greetings;
    public GameObject hiButton;
    public GameObject playerResponse;
    public GameObject receiptionistResponse;
    public GameObject awesomeButton;

    private float timer = 0.0f;
    private bool isHiButtonClicked = false;
    private bool isAwesomeButtonClicked = false;
    [SerializeField]
    private float delay = 2f;
    void Start()
    {
        
    }

    public void HiButton()
    {
        isHiButtonClicked = true;
        timer = 0f;
    }

    public void AwesomeButton()
    {
        isAwesomeButtonClicked = true;
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(isHiButtonClicked == false && isAwesomeButtonClicked == false)
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
    }
}
